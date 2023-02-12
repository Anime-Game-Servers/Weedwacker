﻿using System.Data;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data
{
    internal static class DynamicFloatHelper
    {

        public static float ResolveDynamicFloat(object dynFloat, BaseEntity entity, string configAbilityName)
        {
			uint ability = Utils.AbilityHash(configAbilityName);
			if (dynFloat is double asFloat)
                return (float)asFloat;
            else if (dynFloat is string)
            {
                uint special = Utils.AbilityHash(dynFloat as string);
                if (entity.AbilityManager.AbilitySpecialOverrideMap[ability].ContainsKey(special))
                    return entity.AbilityManager.AbilitySpecialOverrideMap[ability][special];
                else // eg %X+%Y
                    return ResolvePercentageSymbolReferences(dynFloat as string, entity, ability);
            }
            else if (dynFloat is JArray expression)
            {
                return ResolvePolishNotation(expression.ToObject<string[]>(), entity, ability);
            }
            else
            {
                Logger.WriteErrorLine($"Unknown dynamic float expression: {dynFloat}, {dynFloat.GetType()}");
                return 0;
            }
        }
		public static float ResolveDynamicFloat(object dynFloat, BaseEntity entity, uint configAbilityHash)
		{
			if (dynFloat is double asFloat)
				return (float)asFloat;
			else if (dynFloat is string)
			{
				uint ability = configAbilityHash;
				uint special = Utils.AbilityHash(dynFloat as string);
				if (entity.AbilityManager.AbilitySpecialOverrideMap[ability].ContainsKey(special))
					return entity.AbilityManager.AbilitySpecialOverrideMap[ability][special];
				else // eg %X+%Y
					return ResolvePercentageSymbolReferences(dynFloat as string, entity, configAbilityHash);
			}
			else if (dynFloat is JArray expression)
			{
				return ResolvePolishNotation(expression.ToObject<string[]>(), entity, configAbilityHash);
			}
			else
			{
				Logger.WriteErrorLine($"Unknown dynamic float expression: {dynFloat}, {dynFloat.GetType()}");
				return 0;
			}
		}

		private static float ResolvePolishNotation(object[] expression, BaseEntity entity, uint configAbilityHash)
        {
            Stack<float> myStack = new Stack<float>();
            float value;
            uint ability = configAbilityHash;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] is float asFloat)
                    myStack.Push(asFloat);
                else
                {
                    float local;
                    switch (expression[i] as string)
                    {
                        case "Add":
                            local = myStack.Pop() + myStack.Pop();
                            myStack.Push(local);
                            break;
                        case "Mul":
                            local = myStack.Pop() * myStack.Pop();
                            myStack.Push(local);
                            break;
                        default:
                            uint special = Utils.AbilityHash(expression[i] as string);
                            if (entity.AbilityManager.AbilitySpecialOverrideMap[ability].TryGetValue(special, out float fVal))
                            {
                                myStack.Push(fVal);
                                break;
                            }
                            else if (float.TryParse(expression[i] as string, out float floatyFloat))
                            {
                                myStack.Push(floatyFloat);
                                break;
                            }
                            else if (entity is SceneEntity sceneEntity && sceneEntity.FightProps != null && sceneEntity.FightProps.TryGetValue((FightPropType)Enum.Parse(typeof(FightPropType), expression[i] as string), out float fightProp))
                            {
                                myStack.Push(fightProp);
                                break;
                            }
                            else
                            {
                                Logger.WriteErrorLine($"Unknown dynamic float expression: {expression}");
                                return 0;
                            }
                    }
                }
            }
            return myStack.Pop();
        }

        private static float ResolvePercentageSymbolReferences(string dynFloat, BaseEntity entity, uint configAbilityHash)
        {
            uint ability = configAbilityHash;
            var specials = Regex.Matches(dynFloat, @"(?<!\w)#\w+"); // match "%Word"
            foreach (Match match in specials)
            {
                string withoutPerc = Regex.Replace(match.Value, "%", "");
                uint special = Utils.AbilityHash(withoutPerc);
                if (entity.AbilityManager.AbilitySpecialOverrideMap[ability].TryGetValue(special, out float fVal))
                    dynFloat = Regex.Replace(dynFloat, match.Value, fVal.ToString());
                else if (entity is SceneEntity sceneEntity && sceneEntity.FightProps.TryGetValue((FightPropType)Enum.Parse(typeof(FightPropType), match.Value), out float fightProp))
                    dynFloat = Regex.Replace(dynFloat, match.Value, fightProp.ToString());
                else
                {
                    Logger.WriteErrorLine("failed to dereference PercentageSymbolReference");
                    return 0;
                }
            }
            DataTable dt = new();
            return (float)dt.Compute(dynFloat, "");
        }
    }
}
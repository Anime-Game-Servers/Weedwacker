using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Enums
{

    [AttributeUsage(AttributeTargets.Class)]
    public class QuestCondAttribute : Attribute
    {
        public readonly int QuestCondNum;
        public readonly string QuestCondName;

        public QuestCondAttribute(int value)
        {
            QuestCondNum = value;
            QuestCondName = Enum.GetName(typeof(QuestCondType), value);
        }
        public QuestCondAttribute(string name)
        {
            QuestCondNum = (int)Enum.Parse(typeof(QuestCondType), name);
            QuestCondName = name;
        }
    }

    public class QuestContentAttribute : Attribute
    {
        public readonly int QuestContentNum;
        public readonly string QuestContentName;

        public QuestContentAttribute(int value)
        {
            QuestContentNum = value;
            QuestContentName = Enum.GetName(typeof(QuestContentType), value);
        }
        public QuestContentAttribute(string name)
        {
            QuestContentNum = (int)Enum.Parse(typeof(QuestContentType), name);
            QuestContentName = name;
        }
    }
    public class QuestExecAttribute : Attribute
    {
        public readonly int QuestExecNum;
        public readonly string QuestExecName;

        public QuestExecAttribute(int value)
        {
            QuestExecNum = value;
            QuestExecName = Enum.GetName(typeof(QuestExecType), value);
        }
        public QuestExecAttribute(string name)
        {
            QuestExecNum = (int)Enum.Parse(typeof(QuestExecType), name);
            QuestExecName = name;
        }
    }
}
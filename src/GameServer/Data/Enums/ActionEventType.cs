
namespace Weedwacker.GameServer.Data.Enums;

public enum ActionEventType : int
{
	Any = 0,
	ButtonPressed = 1,
	ButtonReleased = 2,
	ButtonPressing = 3,
	ButtonUnpressing = 4,
	ButtonLongPressed = 5,
	ButtonLongPressing = 6,
	ButtonLongReleased = 7,
	ButtonShortPressUp = 8,
	ButtonRepeating = 9,
	AxisActive = 10,
	NegativeButtonRepeating = 11,
}
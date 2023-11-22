
using System.Net.Sockets;

namespace AsteroidsProject;

internal class TheLockedDoor(int passcode)
{
    private int _passcode = passcode;
    private DoorStatusEnum _doorStatus = DoorStatusEnum.Lock;
    
    public void ChangePassCode(int oldPassCode, int newPassCode)
    {
        if(oldPassCode == _passcode)
        {
            _passcode = newPassCode;
            Console.WriteLine("Ok");
            return;
        }
        Console.WriteLine("Operation was not successfully wrong old passcode was entered");
    }

    public void PerformAction()
    {
        Console.WriteLine($"""
            Press 1 to {DoorStatusEnum.Lock}
            Press 2 to {DoorStatusEnum.Unlock}
            Press 3 to {DoorStatusEnum.Open}
            Press 4 to {DoorStatusEnum.Close}
            """);
        int selectedInput = Convert.ToInt32(Console.ReadLine());
        DoorStatusEnum doorStatusAction = (DoorStatusEnum)selectedInput;

        switch (selectedInput)
        {
            case 1:
                {
                    if ((_doorStatus == doorStatusAction) && (_doorStatus == DoorStatusEnum.Lock))
                    {
                        Console.WriteLine($"The Door is already Locked you can only {DoorStatusEnum.Unlock}");
                        return;

                    }
                    if ((doorStatusAction == DoorStatusEnum.Lock) && (_doorStatus == DoorStatusEnum.Unlock))
                    {
                        _doorStatus = DoorStatusEnum.Lock;
                        Console.WriteLine("The Door has been Locked successfully");
                        return;
                    }

                    else
                    {
                        Console.WriteLine($"You cant perform that operation {doorStatusAction}");
                    }

                    break;
                }
            case 2:
                {
                    if ((_doorStatus == doorStatusAction) && (_doorStatus == DoorStatusEnum.Unlock))
                    {
                        Console.WriteLine($"The Door is Unlocked already you can only {DoorStatusEnum.Lock} or {DoorStatusEnum.Open}");
                        return;

                    }
                    if ((doorStatusAction == DoorStatusEnum.Unlock) && (_doorStatus == DoorStatusEnum.Lock))
                    {
                        _doorStatus = DoorStatusEnum.Unlock;
                        Console.WriteLine("The Door has been Unlocked successfully");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You cant perform that operation {doorStatusAction}");
                    }
                    break;
                }
            case 3:
                {
                    if ((_doorStatus == doorStatusAction) && (_doorStatus == DoorStatusEnum.Open))
                    {
                        Console.WriteLine($"The Door is already Open you can only {DoorStatusEnum.Close}");
                        return;

                    }

                    if ((doorStatusAction == DoorStatusEnum.Open) && 
                        (_doorStatus == DoorStatusEnum.Unlock || _doorStatus == DoorStatusEnum.Close))
                    {
                        _doorStatus = DoorStatusEnum.Open;
                        Console.WriteLine("The Door has been Opened successfully");
                        return;

                    }
                    else
                    {
                        Console.WriteLine($"You cant perform that operation {doorStatusAction}");
                    }
                    break;
                }
            case 4:
                {
                    if ((_doorStatus == doorStatusAction) && (_doorStatus == DoorStatusEnum.Close))
                    {
                        Console.WriteLine($"The Door is already Closed you can only {DoorStatusEnum.Open} or {DoorStatusEnum.Lock}");
                        return;

                    }
                    if ((doorStatusAction == DoorStatusEnum.Open) && (_doorStatus == DoorStatusEnum.Open))
                    {
                        _doorStatus = DoorStatusEnum.Close;
                        Console.WriteLine("The Door has been Closed successfully");
                        return;

                    }
                    break;
                }
            default:
                {
                    Console.WriteLine($"You cant perform that operation {doorStatusAction}");
                    break;
                }
        }
    }
    private enum DoorStatusEnum
    {
        Lock = 1,
        Unlock,
        Open,
        Close,
    }
}

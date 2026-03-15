using System;
using System.Collections.Generic;
using System.Text;

namespace TimpLaba2_VirtualMemory.Presenters
{
    public interface IVMTerminalPresenter<T>
    {
        void CreateFile(T arguments);

        void OpenFile(T arguments);

        void InputValue(T arguments);

        void PrintValue(T arguments);
    }
}

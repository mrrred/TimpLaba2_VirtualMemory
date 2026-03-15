using System;
using System.Collections.Generic;
using System.Text;
using TimpLaba2_VirtualMemory.Views;

namespace TimpLaba2_VirtualMemory.Presenters
{
    public class VMTerminalPresenter : IVMTerminalPresenter<string[]>
    {
        protected ITerminalView _view;

        public VMTerminalPresenter(ITerminalView view)
        {
            _view = view;
        }

        public void CreateFile(string[] arguments)
        {
            throw new NotImplementedException();
        }

        public void OpenFile(string[] arguments)
        {
            throw new NotImplementedException();
        }

        public void InputValue(string[] arguments)
        {
            throw new NotImplementedException();
        }

        public void PrintValue(string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}

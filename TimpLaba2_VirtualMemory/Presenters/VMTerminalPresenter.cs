using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using TimpLaba2_VirtualMemory.Models;
using TimpLaba2_VirtualMemory.Views;
using static TimpLaba2_VirtualMemory.Models.VMFileType;

namespace TimpLaba2_VirtualMemory.Presenters
{
    public class VMTerminalPresenter : IVMTerminalPresenter<string[]>
    {
        protected ITerminalView _view;
        protected IVirtualMemmoryFileWorker _fileWorker;
        protected IVirtualMemmoryValueWorker _valueWorker;

        public VMTerminalPresenter(ITerminalView view)
        {
            _view = view;
        }

        public void CreateFile(string[] arguments)
        {
            if (arguments.Length < 2 || arguments.Length > 3)
            {
                _view.DisplayError("Not enough arguments for Create command.");
                return;
            }

            VMFileType.FileType? fileType;

            if (VMFileType.TryConvertStringToFileType(arguments[1], out fileType))
            {
                if (arguments.Length == 2)
                {
                    try
                    {
                        _fileWorker.CreateFile(arguments[0], new VMFileType((VMFileType.FileType)fileType, null));
                    }
                    catch (Exception ex)
                    {
                        _view.DisplayError(ex.Message);
                    }
                }
                else
                {
                    int typeLength;

                    if (!int.TryParse(arguments[2], out typeLength))
                    {
                        _view.DisplayError("Invalid type length argument for Create command.");
                        return;
                    }

                    try
                    {
                        _fileWorker.CreateFile(arguments[0], new VMFileType((VMFileType.FileType)fileType, typeLength));
                    }
                    catch (Exception ex)
                    {
                        _view.DisplayError(ex.Message);
                    }
                }
            }            
        }

        public void OpenFile(string[] arguments)
        {
            if (arguments.Length != 1)
            {
                _view.DisplayError("Not enough arguments for Create command.");
                return;
            }

            try
            {
                _fileWorker.OpenFile(arguments[0]);
            }
            catch (Exception ex)
            {
                _view.DisplayError(ex.Message);
            }
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

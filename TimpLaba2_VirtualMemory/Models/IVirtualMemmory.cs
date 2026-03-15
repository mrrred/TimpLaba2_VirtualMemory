using System;
using System.Collections.Generic;
using System.Text;

namespace TimpLaba2_VirtualMemory.Models
{
    public interface IVirtualMemmoryFileWorker
    {
        void CreateFile(string fileName, string valueType, int? stringLength);

        IVirtualMemmoryValueWorker OpenFile(string fileName);

        void CloseFile();
    }

    public interface IVirtualMemmoryValueWorker : IDisposable
    {
        void WriteValue();

        void ReadValue();
    }
}

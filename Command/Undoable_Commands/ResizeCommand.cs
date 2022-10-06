using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Undoable_Commands
{
    public class ResizeCommand : IUndoableCommand
    {
        private ImageService _service;
        private int _prevSize;
        private History _history;
        
        private int _size; // param for resizing

        public ResizeCommand(ImageService service, History history, int size)
        {
            _service = service;
            _history = history;
            _size = size;
        }
        public void Execute()
        {
            _prevSize = _service.Size;
            _service.Resize(_size);
            _history.Push(this);
        }

        public void Unexecute()
        {
            _service.Resize(_prevSize);
        }
    }
}

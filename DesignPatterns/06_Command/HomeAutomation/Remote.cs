using DesignPatterns._06_Command.HomeAutomation.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.HomeAutomation
{
    public class Remote
    {
        // This is the official version following the book's example.
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _lastExecutedCommand;

        public Remote()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];
            _lastExecutedCommand = new NoCommand();

            // Below assigns default commands that do nothing, so NullPointerRefs are prevented.
            ICommand defaultCommand = new NoCommand();
            for(int i = 0; i < 7;  i++){
                _onCommands[i] = defaultCommand;
                _offCommands[i] = defaultCommand;
            }
        }

        public void SetCommand(int slot, ICommand OnCommand, ICommand OffCommand)
        {
            _onCommands[slot] = OnCommand;
            _offCommands[slot] = OffCommand;
        }

        public void PressOnButton(int slot)
        {
            _onCommands[slot].Execute();
            _lastExecutedCommand = _onCommands[slot];
        }

        public void PressOffButton(int slot)
        {
            _offCommands[slot].Execute();
            _lastExecutedCommand = _onCommands[slot];
        }

        public void PressUndoButton()
        {
            _lastExecutedCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(">>> Remote Control <<< \n");
            for(int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot {i}] ON: {_onCommands[i].GetType().Name}");
                stringBuilder.Append($"\t\tOFF: {_offCommands[i].GetType().Name}\n");
            }

            return stringBuilder.ToString();
        }
    }
}

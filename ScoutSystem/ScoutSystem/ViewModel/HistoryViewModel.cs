using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutSystem.ViewModel
{
    public class HistoryViewModel
    {
        private HistoryModel _historyModel;
        public HistoryModel HistoryModel
        {
            get { return _historyModel; }
            set
            {
                _historyModel = value;
            }
        }
        public HistoryViewModel(string param)
        {
            HistoryModel = new HistoryModel
            {
                pass = param
            };
        }
    }
}

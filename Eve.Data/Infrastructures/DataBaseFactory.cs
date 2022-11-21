using Eve.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Data.Infrastructures
{
    public class DataBaseFactory:Disposable,IDataBaseFactory
    {
        private EveDbSet datacontext;
        public EveDbSet DataContext
        {
            get { return datacontext; }
        }
        public DataBaseFactory()
        {
            datacontext = new EveDbSet();
        }
        protected override void DisposeCore()
        {
            datacontext.Dispose();
        }
    }
}

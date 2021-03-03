using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace TestXafDemo.Module.BusinessObjects.XafAspDemo
{

    public partial class Countries
    {
        public Countries(Session session) : base(session) {  }
        public override void AfterConstruction() { base.AfterConstruction(); Active = true; fActive = true; }
    }

}

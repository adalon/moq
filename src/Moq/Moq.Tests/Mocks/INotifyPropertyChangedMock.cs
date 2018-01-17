﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Stunts;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Threading;
using Moq.Sdk;

namespace Mocks
{
    public partial class INotifyPropertyChangedMock : INotifyPropertyChanged, IStunt, IMocked
    {
        readonly BehaviorPipeline pipeline = new BehaviorPipeline();

        ObservableCollection<IStuntBehavior> IStunt.Behaviors => pipeline.Behaviors;


        public override bool Equals(object obj) => pipeline.Execute<bool>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), obj));
        public override int GetHashCode() => pipeline.Execute<int>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));
        public override string ToString() => pipeline.Execute<string>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

        public event PropertyChangedEventHandler PropertyChanged { add => pipeline.Execute<PropertyChangedEventHandler>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), value)); remove => pipeline.Execute<PropertyChangedEventHandler>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), value)); }

        #region IMocked
        IMock mock;

        IMock IMocked.Mock => LazyInitializer.EnsureInitialized(ref mock, () => new DefaultMock(this));
        #endregion
    }
}
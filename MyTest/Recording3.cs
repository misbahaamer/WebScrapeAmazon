﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording3 recording.
    /// </summary>
    [TestModule("a0d6210e-b2e3-4b05-afd4-b027c81476dd", ModuleType.Recording, 1)]
    public partial class Recording3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Recording3 instance = new Recording3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording3()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording3 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.Text4101' at 129;5.", repo.Explorer.Text4101Info, new RecordItemIndex(0));
            repo.Explorer.Text4101.Click("129;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'calc'.", new RecordItemIndex(1));
            Keyboard.Press("calc");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cortana.Id107' at 116;31.", repo.Cortana.Id107Info, new RecordItemIndex(2));
            repo.Cortana.Id107.Click("116;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Num8Button' at 25;32.", repo.Calculator.Num8ButtonInfo, new RecordItemIndex(3));
            repo.Calculator.Num8Button.Click("25;32");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.MultiplyButton' at 52;38.", repo.Calculator.MultiplyButtonInfo, new RecordItemIndex(4));
            repo.Calculator.MultiplyButton.Click("52;38");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Num8Button' at 30;38.", repo.Calculator.Num8ButtonInfo, new RecordItemIndex(5));
            repo.Calculator.Num8Button.Click("30;38");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.EqualButton' at 23;13.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(6));
            repo.Calculator.EqualButton.Click("23;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Close' at 23;15.", repo.Calculator.CloseInfo, new RecordItemIndex(7));
            repo.Calculator.Close.Click("23;15");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

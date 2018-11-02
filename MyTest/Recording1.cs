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
    ///The Recording1 recording.
    /// </summary>
    [TestModule("b3d42cfb-6f6b-44ca-85bb-f54e4b3e696d", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabIntroduction.TxtUserName' at 67;0.", repo.ApplicationUnderTest.RxTabIntroduction.TxtUserNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.RxTabIntroduction.TxtUserName.Click("67;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabIntroduction.EnterYourName' at 69;8.", repo.ApplicationUnderTest.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.RxTabIntroduction.EnterYourName.Click("69;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Aamer Misbah' with focus on 'ApplicationUnderTest.RxTabIntroduction.EnterYourName'.", repo.ApplicationUnderTest.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.RxTabIntroduction.EnterYourName.PressKeys("Aamer Misbah");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabIntroduction.BtnSubmitUserName' at 19;2.", repo.ApplicationUnderTest.RxTabIntroduction.BtnSubmitUserNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.RxTabIntroduction.BtnSubmitUserName.Click("19;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Welcome, Aamer Misbah!') on item 'ApplicationUnderTest.RxTabIntroduction.LblWelcomeMessage'.", repo.ApplicationUnderTest.RxTabIntroduction.LblWelcomeMessageInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.RxTabIntroduction.LblWelcomeMessageInfo, "Text", "Welcome, Aamer Misbah!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabIntroduction.Reset1' at 14;7.", repo.ApplicationUnderTest.RxTabIntroduction.Reset1Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.RxTabIntroduction.Reset1.Click("14;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

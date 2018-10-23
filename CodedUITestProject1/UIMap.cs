namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

    public partial class UIMap
    {
        public UIMap()
        {
            this.UIMainWindowWindow.UIButtonButton1.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }

        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIButtonButton = this.UIMainWindowWindow.UIButtonButton1;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Click 'Button' button
            Mouse.Click(uIButtonButton, new Point(46, 14));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(50, 35));
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}

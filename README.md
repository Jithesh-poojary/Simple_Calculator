# Simple_Calculator
This is a simple Calculator(desktop) Application using C#

**Here are the steps to create a simple calculator in Windows Forms,**

step1: Create a Windows Application project from file menu
FILE, New, then click Project.

step2: A popup window will appear. Choose “Windows” from templates and choose project “Windows Forms Application.” I have named it “Simple Calculator.”

step3: Create the Form design as follows by using buttons and textbox.

step4: Add 0-9, sign (/,*, -, +, %) buttons, backspace, Clear (C), point (.) buttons.

step5: Add a textbox to show the results.

step6: On each button click use the following login,
                                                           private void btn0_Click(object sender, EventArgs e)  
                                                             {  
                                                                 txtResult.Text = txtResult.Text + "0";  
                                                            } 

step7: On operations buttons (+,-, /,*, %) take care of the following cases.

.The signs should not be at first place in the textbox i.e. +1, /2 etc.
.If you press point(.) then in add zero before point i.e. 0.9
.For Backspace button remove the last character from the textbox.
.For C button clear the text of the text box.
.The signs should not appear twice i.e. 4++,9**
.The point should not come twice i.e. 2.3.5
.Cannot divide by zero.
.Cannot find modulus by Zero.

step8: Now we will follow the Microsoft Calculator logic for calculations.

step9: When we press digit sign then again we press sign then result of first expression will be used for next expression i.e.
       5+8+ then result will be 13+ on the result section.

step10: We have to take care of integer numbers as well as float numbers.

step10: For Equal button I have used switch statement.





   M S B A M L   `   `   `  ����T  PStudent Management System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Student_Management_System.ViewModel#Student_Management_System.ViewModel  5   
   Q-clr-namespace:Student_Management_System.ViewsStudent_Management_System.Views  5   	   4    .Student_Management_System.Views.AddAdminWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   @vm1clr-namespace:Student_Management_System.ViewModel     5   
   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Student_Management_System.Views     5   	     � Title$  AddAdminWindow��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   
������ $	��400��5   	   $	��400��5   	    � 
ResizeMode$ NoResize=�5   	    � DataContext 5      :   4Student_Management_System.ViewModel.AddAdminWindowVM  5   
   .��5      � $	��400��6   $	��400��6   .+�5   
   ��  �� CornerRadius$ 30��6   $��5q�6#   
���������5      �� 5       �� ImageSource$ /Images/home_page.png��6    j� Stretch$
 None=�5      ._�5      �� $ 25��6   	 J� Opacity$
	 0.85Q�5      $��-2,0,2,0q�6    ��5      �� 5       
 �� 
StartPoint$	
 0,1&�6*    �� EndPoint$	 1,0&�6;   .��5!      �  � Color$ #4a5159��6'    � Offset$ 0Q�67   � 5"      $ #0f1112��6'   $	 0.5Q�67   5#      5%      5&      �� 5'   
   $��20q�6   $��Center=�6!   $��Center=�6>   .+�5(      �� $��Username��6   
�������$��20(�6:   �� 5)      -   5         ��Name$ UserNameBox��5)   -   
������ $��0 0 0 2q�6[   
�������$��18(�6�   ��6   �� *User+6�   �� 5*      $��Password��6   
�������$��20(�6:   �� 5+      -   5        $ PasswordBox��5+   ,   
������ $��0 0 0 2q�6Z   
�������$��18(�6�   ��6   �� *Pass+6�   �� 5,      $	��100��6   $��20(�6!   $��40��60   $��60 20q�6<   $	��Add��6K   ��6Y   �� *saveCommand+��5-      �� 5.       �� 
TargetType" ��6   .�5/      ��  �� Property � �� �� Value
 ��� �67    �� Triggers 50      P� 51       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �52   "   ��  � �� �#164DFF6?   53      55      ��58      �� 59       �� 
TargetType" ��6&   .R�5:      �� $	��100��6!   $��40��6-   $ 10��5;   !   #��z��5<   !   ._�5=      �� $��Center=�6/   $��Center=�5>   3   5?      5@      5C      5D      �� 5E   
   -   5         ��Name$ CloseApp��5E         ExitApp#��[  5F      5G      5H      5I      
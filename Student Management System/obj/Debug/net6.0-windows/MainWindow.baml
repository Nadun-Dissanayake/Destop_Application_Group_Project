   M S B A M L   `   `   `  ����T  PStudent Management System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Student_Management_SystemStudent_Management_System  5   	   Q-clr-namespace:Student_Management_System.ViewsStudent_Management_System.Views  5   	   *    $Student_Management_System.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Student_Management_System     5   	   ;v-clr-namespace:Student_Management_System.Views     5   	     � Title$  LoginWindow��5	   	   $	��650��5
   	   $	��600��5   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � DataContext 5      ,   &Student_Management_System.MainWindowMV  5   
   .��5      ��  �� CornerRadius$ 70��6   $	��20 q�6   $��5q�6-   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      � 	 � Color$	 #24FF92��6   
 � Offset$
 0Q�6/   � 5      $	 Yellow��6   $	
 0.5Q�6.   � 5      $	 Green��6   $
 1Q�6-   5      ��5    
   �� 5!      $ 0.5, 0.1&�6"   $ 0.9, 0.4&�68   .��5"      � $	 #212529��6   $
 0.Q�6/   � 5#      $	 DarkCyan��6   $	
 0.5Q�60   � 5$      $	 #48FF��6   $
 1Q�6-   5&      ._�5-   
   �� $��
15,50,15,3q�6    �� Orientation$ Vertical=�6)   .+�5.      �� $��ESA ACADEMY��6   ���#99cc99$
��Bold"�6?   $��28(�6Q   $��Center=�6_   �� 5/      $��/Images/logo.jpeg��6   $	��100��6/   $	��100��6;   $��Center=�6H   �� 51      $��Student Management System��6   ���#99cc99$
��Bold"�6M   $��25(�6_   $��Center=�6m   �� 52      $%��Log in to your existing account��6   
�������$
��Bold"�6Q   $��18(�6c   $��Center=�6q   �� 53      6   �� 54      $��Username��6   
�������$��20(�6:   �� 55      -   5         ��Name$ UserNameBox��55   1   $��0 0 0 2q�6F   
������ 
�������$��18(�6�   ��6   �� *
UserName+6�   �� 56      $��Password��6   
�������$��20(�6:   1   +Student_Management_System.Views.PasswordBox  57      -   5          Name$ passwordBox��57   l   $��0 0 0 2q�6�   
�������$��18(�6�   
������    Password 6   �� *
Password+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 58      $	��200��6   $��20(�6!   $��40��6/   $��Login As User��6;   $��10q�6u   ��6S   �� *Login1Command+��59      �� 5:       �� 
TargetType" ��6   .�5;      ��  �� Property � �� �� Value �#00b3b367    �� Triggers 5<      P� 5=       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5>   "   ��  � �� �#00ffff6?   5?      P� 5@       �@J�IsMouseCaptured$
 True��6A   . �5A   "   ��  � �� �#00b3b36?   5B      5D      ��5G      �� 5H       �� 
TargetType" ��6&   .R�5I      �� $ 10��5J   !   #��z��5K   !   ._�5L      �� $��Center=�6/   $��Center=�6J   5M      5N      5P      �� 5R      $	��200��6   $��20(�6!   $��40��5S      $��10q�6!   $��Login As Admin��6-   ��6F   �� *Login2Command+��5T      �� 5U      " ��6   .�5V      ��  � �� �#00b3b367    5W      P� 5X       �@J�IsMouseOver$
 True��6=   . �5Y   "   ��  � �� �#00ffff6?   5Z      P� 5[       �@J�IsMouseCaptured$
 True��6A   . �5\   "   ��  � �� �#00b3b36?   5]      5_      ��5a      �� 5b      " ��6&   .R�5c      �� $ 10��5d   !   #��z��5e   !   ._�5f      �� $��Center=�6/   $��Center=�6J   5g      5h      5j      5k      5l      5m      
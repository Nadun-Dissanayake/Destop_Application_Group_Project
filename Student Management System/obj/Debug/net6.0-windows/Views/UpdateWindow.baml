   M S B A M L   `   `   `  ����T  PStudent Management System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Student_Management_System.ViewModel#Student_Management_System.ViewModel  5   	   Q-clr-namespace:Student_Management_System.ViewsStudent_Management_System.Views  5   	   2    ,Student_Management_System.Views.UpdateWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @vm1clr-namespace:Student_Management_System.ViewModel     5   	   ?local-clr-namespace:Student_Management_System.Views     5   	     � Title$  UpdateWindow��5	   	   $	��600��6   $	��622��6+    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      8   2Student_Management_System.ViewModel.UpdateWindowVM  5   
   .��5      � .+�5   
   ��  �� CornerRadius$ 25,25,25,25��6   ��5      �� 5       �� ImageSource$ /Images/1.jpg��6    j� Stretch$
 None=�5      5      �� 5   
   $ 25��6   $��1q�5       J� Opacity$
 0.85Q�5      $��-2,0,0,0q�6    ��5      �� 5      	 �� 
StartPoint$		 0,1&�6&   
 �� EndPoint$	
 1,0&�67   .��5      �  � Color$ #4a5159��6#    � Offset$ 0Q�63   � 5       $ #0f1112��6#   $	 0.5Q�63   5!      ._�5$      ��  �� Orientation$ Vertical=�6   $��20q�60   .+�5%      �� $'��!Enter the data of the new student��6   ���#b0b9c6$��25(�6Z   $��0 40 0 5q�6h   �� 5&      ���#b0b9c6$	��0 5q�61   6@   �� 5'      $ 
Horizontal=�6   .+�5)      �� $	��5,0q�6    $��
First Name��6-   $��20(�6?   $	��200��6M   ���#b0b9c6 �� TextAlignment$
 Left=�6n   �� 5*      
�������$��10 10q�6   $	��380��6�   
������ $��0 0 0 2q�6�   ��61   �� *SelectedUser.First_name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5+      �� 5-      $ 
Horizontal=�6   .+�5.      �� $	��5,0q�6    $��	Last Name��6-   $��20(�6>   $	��200��6L   ���#b0b9c66X   �� 5/      
�������$��10 10q�6~   $	��380��6�   
������ $��0 0 0 2q�6�   ��61   �� *SelectedUser.Last_name+$ PropertyChanged=�6�   50      �� 52      $ 
Horizontal=�6   .+�53      �� $	��5,0q�6    $��Address��6-   $��20(�6<   $	��200��6J   ���#b0b9c66V   �� 54      
�������$��10 10q�6{   $	��380��6�   
������ $��0 0 0 2q�6�   ��61   �� *SelectedUser.Address+$ PropertyChanged=�6�   55      �� 57      $ 
Horizontal=�6   .+�58      �� $	��5,0q�6    $��Telephone Number��6-   $��20(�6E   $	��200��6S   ���#b0b9c66_   �� 59      
�������$��10 10q�6�   $	��380��6�   
������ $��0 0 0 2q�6�   ��61   �� *SelectedUser.Telephone_Number+$ PropertyChanged=�6�   5:      �� 5<      $ 
Horizontal=�6   �� 5>      $ 
Horizontal=�6   �� 5@      $ 
Horizontal=�6   �� 5B      $ 
Horizontal=�6   .+�5C      �� $	��622��6   $��50��6)   $��10 20q�65   $
��Save��6D   $��Center=�5D      
���   �$
��Bold"�5E      $��20(�6+   ��5C   S   �� *saveCommand+��5G      �� 5H       �� 
TargetType" ��6$   .�5I   "   ��  �� Property � �� �� Value �#00FFFF6?    �� Triggers 5J   "   P� 5K   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5L   *   ��  � �� �#164DFF6G   5M   '   5O      ��5R      �� 5S       �� 
TargetType" ��6.   .R�5T   "   �� $	��200��6)   $��40��65   
���   �$��2q�5V   !   $ 10��5W   !   #��z��5X   !   ._�5Y   &   �� $��Center=�67   $��Center=�5Z   3   5[   #   5\      5^      5_      5`      5a      �� 5c   
   -   5         ��Name$ CloseApp��5c         ExitApp#��[  5d      5e      5g      5h      
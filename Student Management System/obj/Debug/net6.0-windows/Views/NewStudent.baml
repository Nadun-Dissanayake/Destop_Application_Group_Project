   M S B A M L   `   `   `  ����T  PStudent Management System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Student_Management_System.ViewModel#Student_Management_System.ViewModel  5      Q-clr-namespace:Student_Management_System.ViewsStudent_Management_System.Views  5      0    *Student_Management_System.Views.NewStudent   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @vm1clr-namespace:Student_Management_System.ViewModel     5      ?local-clr-namespace:Student_Management_System.Views     5         
Page_Style#��[  5        � DataContext  5      6   0Student_Management_System.ViewModel.NewStudentVm  5   
   .��5      � $	��622��6   $	��600��6   .+�5   
   ��  �� CornerRadius$ 	0 25 25 0��6   ��5      �� 5       �� ImageSource$ /Images/1.jpg��6    j� Stretch$
 None=�5      ._�5      �� $ 	0 25 25 0��6    J� Opacity$
 0.85Q�5      $��-2,0,0,0q�6    ��5      �� 5       �� 
StartPoint$	 0,1&�6*    �� EndPoint$	 1,0&�6;   .��5      �  � Color$ #4a5159��6'    � Offset$ 0Q�67   � 5      $ #0f1112��6'   $	 0.5Q�67   5      5       5!      �� 5"   
   	 �� Orientation$	 Vertical=�6   $��15q�6,   .+�5#      �� $'��!Enter the data of the new student��6   
�������$��35(�5$      $��0 40 0 5q�6&   �� 5%      ���#b0b9c6$	��0 5q�6-   6<   �� 5&      $	 
Horizontal=�6   .+�5(      �� $	��5,0q�6   $��
First Name��6*   $��25(�6<   $	��200��6J   
�������
 �� TextAlignment$

 Left=�6i   �� 5)      
�������$��16(�6-   $��10 10q�6W   $	��380��6f   
������ $��0 0 0 2q�6�   ��6;   �� *
First_name+6�   5*      �� 5,      $	 
Horizontal=�6   .+�5-      �� $	��5,0q�6   $��	Last Name��6*   $��25(�6;   $	��200��6I   
�������6U   �� 5.      
�������$��16(�6-   $��10 10q�6W   $	��380��6f   
������ $��0 0 0 2q�6�   ��6;   �� *	Last_name+6�   5/      �� 51      $	 
Horizontal=�6   .+�52      �� $	��5,0q�6   $��Address��6*   $��25(�69   $	��200��6G   
�������6S   �� 53      
�������$��16(�6-   $��10 10q�6T   $	��380��6c   
������ $��0 0 0 2q�6�   ��6;   �� *	Address+6�   54      �� 56      $	 
Horizontal=�6   .+�57      �� $	��5,0q�6   $��Reg No��6*   $��25(�68   $	��200��6F   
�������6R   �� 58      
�������$��16(�6-   $��10 10q�6R   $	��380��6a   
������ $��0 0 0 2q�6�   ��6;   �� *Regno+6�   59      �� 5;      $	 
Horizontal=�6   .+�5<      �� $	��5,0q�6   $��Telephone No��6*   $��25(�6>   $	��200��6L   
�������6X   �� 5=      
�������$��16(�6-   $��10 10q�6R   $	��380��6a   
������ $��0 0 0 2q�6�   ��6;   �� *Telno+6�   5>      �� 5D      $	 
Horizontal=�6   �� 5F      $	 
Horizontal=�6   .+�5G      �� $	��622��6   $��50��6%   $��10 20q�61   $
��Save��6@   $��Center=�5H      
���   �$
��Bold"�5I      $��20(�6+   ��5G   O   �� *saveCommand+��5K      �� 5L       �� 
TargetType" ��6    .�5M      ��  �� Property � �� �� Value �#00FFFF6;    �� Triggers 5N      P� 5O   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5P   &   ��  � �� �#164DFF6C   5Q   #   5S      ��5V      �� 5W       �� 
TargetType" ��6*   .R�5X      �� $	��200��6%   $��40��61   $ 10��5Y   !   #��z��5Z   !   ._�5[   "   �� $��Center=�63   $��Center=�5\   3   5]      5^      5`      5a      5b      5c      5d      
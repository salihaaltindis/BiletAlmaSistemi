   M S B A M L   `   `   `  ����F  BWpfLoginApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfLoginAppWpfLoginApp  5   	       WpfLoginApp.SignUp   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfLoginApp     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  SignUp��5	   	   $	��496��6   $	��560��6%   $��20(�61   ���	#FFBEFFEB � Icon$ Resimler/split.jpg��6V    � WindowStartupLocation$ CenterScreen=�6p   .��5      �� $��20q�6    �� Padding$ 20q�6   ���	#FF2B2928 �� CornerRadius$ 20��6=   ._�5   
   �� .+�5      �� $��Sign Up��6   
�������$��20(�69   $��Center=�6G   6f   �� 5      
�������6   �� 5      $��	User Name��6   
�������$��18(�6;   � 5       � ColumnDefinitions 5      �� 5      $��3* �6'   �� 5      $��* �6'   .+�5      �� -   5         ��Name$ txtusername��5      
�������$��Center=�6B   ���	#FF9BA3B0$��2q�6{   6�   �� 5      -   5        $��userNameValidate��5   -   $y�Visible=�6   
���  ��$�� ��6W   $��2��6b   6t   5      �� 5      $
��Name��6   
�������$��18(�66   � 5       5      �� 5      $��3* �6'   �� 5      $��* �6'   .+�5!      �� -   5        $ txtname��5!      
�������$��Center=�6>   ���	#FF9BA3B0$��2q�6w   6�   �� 5"      -   5        $��nameValidate��5"   .   $y�Visible=�6   $�� ��6B   
���  ��$��2��6^   6q   5#      �� 5&      $��Password��6   
�������$��18(�6:   � 5'       5(      �� 5)      $��3* �6'   �� 5*      $��* �6'   .+�5,      G� -   5         G�Name$ txtpassword��5,      $��Center=�63   
����������	#FF9BA3B0$��2q�6�   6�   �� 5-      -   5        $��passwordValidate��5-   -   $y�Visible=�6   $�� ��6E   
���  ��$��2��6b   6t   5.      �� 51      $��Again Password��6   
�������$��18(�6@   � 52       53      �� 54      $��3* �6'   �� 55      $��* �6'   .+�57      G� -   5        $ txtagainpassword��57      $��Center=�68   
����������	#FF9BA3B0$��2q�6�   6�   �� 58      -   5        $��passwordAgainValidate��58   -   $y�Visible=�6   $�� ��6J   
���  ��$��2��6f   6x   59      �� 5<      -	   5        $��18(�5<      $��Register��6#   ���	#FF9BA3B0
�������$��10,10,293,10q�6`   $��29��6v    J� RenderTransformOrigin$ 0.037,1.194&�6�   6�   5=      5?      5@      
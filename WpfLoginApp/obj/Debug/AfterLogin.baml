   M S B A M L   `   `   `  ����F  BWpfLoginApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfLoginAppWpfLoginApp  5   	       WpfLoginApp.AfterLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfLoginApp     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        
���   �  � Title$  
AfterLogin��5
   	   $	��700��6   $	��800��6)    � WindowStyle$
 None=�6L   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      �� 5      $��3* �6   .+�5   
   �� $��0��6   $��0��6   ���	#FF3F82D3._�5      �  5      �� 5      $��35 �6$   �� 5      .+�5      ]� $��Center=�6   $��Center=�69   .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$	 Bus=�6.   $��25��69   $��25��6D   
�������6P   �� 5!      $��BİLET SİSTEMİ��6   
�������6I   5"      �� 5#      $��1��6   ._�5$      ]� $��Center=�6    $��Center=�6;   .+�5%        $ 
LibraryAdd=�62   $	��100��6D   $	��100��6P   
�������6]   5&      5'      5(      5)      �� 5,   
   $��1��6   ���	#FF3F82D3 �� Padding$ 5q�65   ._�5-      �� .+�50      �� -   5        
�������$��3 0 0 0q�50   -   $��50��6G      MaterialDesignFlatButton#��[  6S   $
��Left=�6�   .��51      ]� $��Center=�6    .+�52        $ BusinessCard=�62   $��32��6F   $��32��6Q   
�������6]   �� 53      $��Bilet Al��6    
�������63   54      55      �� 56      -   5        
�������$��3 0 0 0q�56   -   $��50��6G   #��[  6S   $
��Left=�6�   .��57      ]� $��Center=�6    .+�58        $ FileCancelOutline=�62   $��32��6K   $��32��6V   
�������6b   �� 59      $��Bilet İptal Et��6    
�������69   5:      5;      �� 5<      -   5        
�������$��3 0 0 0q�5<   -   $��50��6G   #��[  6S   $
��Left=�6�   .��5=      ]� $��Center=�6    .+�5>        $ SettingsOutline=�62   $��32��6I   $��32��6T   
�������6`   �� 5?      $��Hesap Düzenle��6    
�������68   5@      5A      5C      5D      �� 5E   
   $��1��6   ���	#FF3F82D3._�5F      �  5G      �� 5H      $��35 �6$   �� 5I      .+�5L      �� 
�������._�5M      �� 
�������$��0��64    �� Orientation$ 
Horizontal=�6A   $��Right=�6Z   .+�5N      �� -   5         ��Name$ minimizingButton��5N   !   $��_��6;   6h   �� 5O      -   5        $ maximizingButton��5O   !   $	��| |��6;   6j   �� 5P      -   5        $ closingButton��5P   !   $��X��68   6b   5Q      5R      �� 5S      $��1��6   ._�5T      �� -   5        $��WelcomeLabel��5T   g   $��Center=�6   $��Center=�69   
�������$��Hosgeldiniz��6|   6�   5U      5W      5X      �� 5Y   
   $��1��6   $��1��6   ._�5Z      � -	   5        $��UserControlGrid��5Z      ���	#FFCFCFCF5]      5^      5`      5a      
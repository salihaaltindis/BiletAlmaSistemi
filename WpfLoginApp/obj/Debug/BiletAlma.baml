   M S B A M L   `   `   `  ����F  BWpfLoginApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfLoginAppWpfLoginApp  5          WpfLoginApp.BiletAlma   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WpfLoginApp     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        
���   �.��5      �   � ColumnDefinitions  5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   �� $��10q�6   $��0��6   ._�5      �� $
��Left=�6   $	��180��64   $	��300��6@   $	��Top=�6M   .+�5      �� $��0 10 0 0q�6   $��Nereden��6*   $
��Bold"�6<   �� 5      -   5        $��neredencmbx��5   ^   $��0 10 0 0q�6K    �� 
IsEditable . 6�   �� 5      $��0 10 0 0q�6   $��Nereye��6,   $
��Bold"�6=   �� 5      -   5        $��
nereyecmbx��5   /   $��0 10 0 0q�6    . 6U   �� 5!      $��0 10 0 0q�6   $��Tarih��6*   $
��Bold"�6:   (  "System.Windows.Controls.DatePicker  5"      -   5        $��seferTarihi��5"   m   $��0 10 0 0q�6Z      SelectedDate 6   �� *
DateTime+ �� StringFormat$ 
dd.MM.yyyy��6�   �� 5#      -   5        $��10 10q�5#      .��6?   Seferleri Listele6R   5%      5&      � 5*   
   -   5         �Name$ datagrid��5*   B   $��1��6   $��0��6   $y�Visible=�6-   .+�5,      &   System.Windows.Controls.DataGrid  -   5          Name$ seferListeleGrid��5,         AutoGenerateColumns .     CanUserAddRows .  $��	5,10,5,70q�5-      $��Stretch=�6   $��Stretch=�62   	   RowBackground	 �#fff$
��Bold"�5.      ���#525252��. $	��390��5/   &   
   AlternatingRowBackground
 �#f2f2f2���#000$��1q�50   7   $��Visible=�51      $
��Auto=�52         Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ nereden��6)      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ��  �� Path$ nereden�6]     55      $ nereye��6)    .  69   �� $ nereye�6[     56      $ tarih��6)    .  69   �� $ tarih�6Z     57      $
 saat��6)    .  67   �� $
 saat�6W     58      $ 	kontenjan��6)    .  6<   �� $ 	kontenjan�6a     59      $ fiyat��6)    .  68   �� $ fiyat�6Y     5:      $ sefer_id��6)    .  6;   �� $ sefer_id�6_   4  .System.Windows.Controls.DataGridTemplateColumn  5;         CellTemplate 5<      �� 5=      .R�5>   "   �� $��biletAl��6)   -   5        $��	Bileti Al��5>   8   6M   5?      5A      5C      5D      � 5E   
   -	   5        $ KoltukSecGrid��5E   Q   $	��Top=�6   $��Center=�6)   $��1q�6F   
�������$��1��6   $��1��6�   5H      5J      5K      
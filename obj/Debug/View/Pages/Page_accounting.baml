   M S B A M L   `   `   `  ????J  Fhome_accounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:home_accounting.View.Pageshome_accounting.View.Pages  5      0    *home_accounting.View.Pages.Page_accounting   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:home_accounting.View.Pages     5        N? Title$  Page_accounting??5	      .??5      ? .+?5   
   ?? $	??Top=?6   $??Right=?6-    ?? Orientation$ 
Horizontal=?5      $??30??6.   .+?5      ?? -   5         ??Name$ add_account??5   (   $??Добавить??6   
???????$??14(?5      $
??Bold"?6#   $??0 0 10 0q?65   ?? 5      -   5        $ delete_account??5   '   $??Удалить??6   
???????$??14(?5      $
??Bold"?6#   $??0 0 10 0q?65   ?? 5      $(??"Поиск по категории??6   $??16(?62   $	??150??5      $	??Top=?6$   ?? 5      -   5         ??Name$ search_category??5      $	??150??6/   $??14(?5      $
??Bold"?6#   $??0 0 10 0q?65   5      ?? 5      $(??"Фильтрация по типу??6   $??16(?62   $	??150??5      $	??Top=?6$   ?? 5      -   5         ??Name$ types_categories??5   #   $	??150??6    ?? SelectedItem 5      ?? *category_type+5      5       ?? 5"   
   $??Center=?6   $??0 35 0 0q?62   .+?5#      &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid??5#         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6E   	   
IsReadOnly	 . 
   Columns
 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$# Дата добавления??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   ?? *
date_add+  5'      $ Приход/Расход??6)    6@   ?? *category_type.name+  5(      $ Категория??6)    6<   ?? *Categories.name+  5)      $ 
Сумма??6)    68   ?? *sum+  5*      $ Коммент??6)    6:   ?? *	comment+4  .System.Windows.Controls.DataGridTemplateColumn  5+         Width$
 auto 6-      CellTemplate 5,      ?? 5-      .R?5.   "   ?? $ edit_account??6<   -   5        $??Изменить??5.   )   
???????$??14(?50   <   $
??Bold"?51   )   52      54      56      57      59      5:      
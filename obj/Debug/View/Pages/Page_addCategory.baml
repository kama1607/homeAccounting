   M S B A M L   `   `   `  ????J  Fhome_accounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:home_accounting.View.Pageshome_accounting.View.Pages  5      1    +home_accounting.View.Pages.Page_addCategory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:home_accounting.View.Pages     5        N? Title$  Page_addCategory??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??Center=?6   .+?5      ?? $??Center=?6   $??Center=?64   $
??0 25q?5      .+?5      ?? $??Доход/Расход??6    ?? TextAlignment$ Center=?60   
???????6G   5      5      ?? 5   
   $??Center=?6   $??1??60   .+?5      ?? $??Center=?6   $??Center=?64   .+?5       ?? -   5         ??Name$ select_category_type??5#       ?? DisplayMemberPath$
 name??5!      $	??180??5"       ?? SelectedItem 5       ?? *category_type+5#      5$      5%      ?? 5(   
   $??Center=?6   $??0??60   $??1??6@   .+?5)      ?? $??Center=?6   $??Center=?64   $
??0 25q?5*      .+?5+      ?? $)??#Название категории??6   $ Center=?66   
???????6M   5,      5-      ?? 5/   
   $??Center=?6   $??1??60   $??1??6=   .+?50      ?? $??Center=?6   $??Center=?64   .+?51      ?? -   5         ??Name$
 name??52      $	??200??51   0    ?? TextAlignment$ Center=?6<   ??6   ?? *name+52      53      54      ?? 56   
   	 ?? Orientation$	 
Horizontal=?6   $??2??6.   $??2??6B   .+?57      ?? -   5        
 ??Name$
 btn_back??59      $??30??57      $??0 0 25 0q?6!   $	??200??58      $??
Назад??6   59   #   ?? 5;      -   5        $
 btn_add??5=      $??30??5;      $	??200??5<      $??Добавить??6   5=   "   5>      5@      5A      
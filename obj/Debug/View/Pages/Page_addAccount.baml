   M S B A M L   `   `   `  ????J  Fhome_accounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:home_accounting.View.Pageshome_accounting.View.Pages  5      0    *home_accounting.View.Pages.Page_addAccount   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:home_accounting.View.Pages     5        N? Title$  Page_addAccount??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ?? $??50??6   $??Center=?6!   .+?5      ?? $??Center=?6   $??Center=?65   $
??0 25q?5      .+?5      ?? $#??Дата добавления??6    ?? TextAlignment$ Center=?63   
???????6J   5       5!      ?? 5#   
   $??1??6   $??0??6%   $??Center=?62   .+?5$      ?? $??Center=?6   $??Center=?64   $??0 10 0 0q?5%      .+?5&      (  "System.Windows.Controls.DatePicker  -   5          Name$ datepick??5(         FirstDayOfWeek$ Monday=?5&         IsDropDownOpen . $	??200??5'         SelectedDate 6)   ?? *
date_add+   DisplayDate 5(   /   ?? *DisplayDate.Date.Date.Now+	 ?? ElementName$	 datepick??
 ?? Mode$
 OneWay=?5)      5*      ?? 5-   
   $??50??6   $??1??6!   $??Center=?6.   .+?5.      ?? $??Center=?6   $??Center=?64   $
??0 25q?5/      .+?50      ?? $??Приход/Расход??6   $ Center=?61   
???????6H   51      52      ?? 54   
   $??Center=?6   $??1??60   $??1??6@   .+?55      ?? $??Center=?6   $??Center=?64   .+?56      ?? -   5         ??Name$ select_type??59      $	??180??58      59   0   5:      5;      ?? 5>   
   $??Center=?6   $??2??60   .+?5?      ?? $??Center=?6   $??Center=?64   $
??0 25q?5@      .+?5A      ?? $??Категория??6   $ Center=?6-   
???????6D   5B      5C      ?? 5E   
   $??Center=?6   $??1??60   $??2??6@   .+?5F      ?? $??Center=?6   $??Center=?64   .+?5G      ?? -   5        $ select_category??5J      $	??180??5I      5J      5K      5L      ?? 5O   
   $??Center=?6   $??0??60   $??3??6@   .+?5P      ?? $??Center=?6   $??Center=?64   $
??0 25q?5Q      .+?5R      ?? $??
Сумма??6   $ Center=?6)   
???????6@   5S      5T      ?? 5V   
   $??Center=?6   $??3??60   $??1??6=   .+?5W      ?? $??Center=?6   $??Center=?64   .+?5X      ?? -   5         ??Name$ summa??5Y      $	??200??5X   /    ?? TextAlignment$ Center=?6;   ??6   ?? *sum+5Y      5Z      5[      ?? 5^   
   $??Center=?6   $??0??60   $??4??6@   .+?5_      ?? $??Center=?6   $??Center=?64   $
??0 25q?5`      .+?5a      ?? $??Коммент??6   $ Center=?6+   
???????6B   5b      5c      ?? 5e   
   $??Center=?6   $??4??60   $??1??6=   .+?5f      ?? $??Center=?6   $??Center=?64   .+?5g      ?? -   5        $
 comm??5h      $	??200??5g   3   $ Center=?6?   ??6   ?? *	comment+5h      5i      5j      ?? 5l   
    ?? Orientation$ 
Horizontal=?6   $??2??6.   $??5??6B   .+?5m      ?? -   5         ??Name$ btn_back??5o      $??30??5m      $??0 0 25 0q?6!   $	??200??5n      $??
Назад??6   5o   #   ?? 5q      -   5        $ btn_add??5s      $??30??5q      $	??200??5r      $??Добавить??6   5s   "   5t      5v      5w      
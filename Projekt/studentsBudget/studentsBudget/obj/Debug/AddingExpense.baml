   M S B A M L   `   `   `  ����I  EstudentsBudget, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:studentsBudgetstudentsBudget  5   	   "    studentsBudget.AddingExpense   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:studentsBudget     5   	     � Title$  AddingExpense��5	   	   $	��500��6   $	��500��6,   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��2* �6   6,    � RowDefinitions 5   
   �� 5      $��3* �6   6*   �� 5      $��2* �6   6*   .+�5   
   �� $��0��6   $��0��6%   $��20q�62   .+�5      �� $��5q�6   $��Nazwa: ��6   $
��Left=�61   $��Center=�6L   $��16(�6g   $
��Bold"�6u   6�   �� 5      $��5q�6   $��Wartość: ��6   $
��Left=�63   $��Center=�6N   $��16(�6i   $
��Bold"�6w   6�   �� 5      $��5q�6   $��Data: ��6   $
��Left=�60   $��Center=�6K   $��16(�6f   $
��Bold"�6t   6�   �� 5      $��5q�6   $��Kategoria: ��6   $
��Left=�65   $��Center=�6P   $��16(�6k   $
��Bold"�6y   6�   5      �� 5   
   $��1��6   $��0��6%   $��20q�62   .+�5      �� -   5        $��NameItemTextBox��5      $��5q�6-   $��30��68   $	��200��6D   $��16(�6P   $�� ��6^   �� 5      -   5        $��ValueItemTextBox��5      $��5q�6.   $��30��69   $	��200��6E   $��16(�6Q   $�� ��6_   �� 5      -   5        $��DateItemTextBox��5      $��5q�6-   $��30��68   $	��200��6D   $��16(�6P   $�� ��6^   �� 5      -   5        $��CategoriesBox��5      $��5q�6,   $��16(�67   $��30��6E   $	��200��6Q   .@�5      �� $��Studia��6   �� 5      $��	Transport��6   �� 5       $��Jedzenie��6   �� 5!      $��Rachunki��6   �� 5"      $��Rozrywka��6   �� 5#      $
��Inne��6   5$      5%      � 5&   
   $��1��6   $��1��6$   $��20q�62   .+�5'      �� -   5        $��CancelButton��5'      $��Anuluj��6)   $��30��6;   $	��120��6G   $	��Top=�6S   $��10q�6k   6w   �� 5(      -   5        $��
SaveButton��5(      $��Dodaj��6'   $��30��68   $	��120��6D   $	��Top=�6P   $��10q�6h   6t   5)      5*      5+      
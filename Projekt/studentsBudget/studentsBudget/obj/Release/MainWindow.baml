   M S B A M L   `   `   `  ���� I  EstudentsBudget, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:studentsBudgetstudentsBudget      studentsBudget.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:studentsBudget       � Title$  
MainWindow��$	��600��$	��800��.���  � ColumnDefinitions �� $��8* ��� $��2* � � RowDefinitions �� $��1* ��� $��1* ��� $��5* �.+��� $��0��$��0��$��20q�$��SALDO: ��$��Right=�$��Center=�$��24(�$
��Bold"�
���   ��� -   $��BalanceValueLabel��$��1��$��0��$��20q�$	��...��$
��Left=�$��Center=�$��24(�$
��Bold"�� $��0��$��1��$��Center=�.+��� -   $��ShowIncomsButton��$��Pokaż wpływy��$��30��$	��120��$	��Top=�$��10q��� -   $��ShowExpensesButton��$��Pokaż wydatki��$��30��$	��120��$	��Top=�$��10q��� -   $��ShowCreditsButton��$��Pokaż pożyczki��$��30��$	��120��$	��Top=�$��10q��� -   $��ShowAllButton��$��Pokaż wszystko��$��30��$	��120��$	��Top=�$��10q��� -   $��SummaryView��$��0��$��2��$��20q�$��12(�����  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=� �� View �� ! �� ColumnHeaderContainerStyle �� " ��.���  �@J�IsHitTestVisible .  .P��� $��Nazwa�� �� Width$	 100��	 �� DisplayMemberBinding	 �� *Name+�� $��Kwota��$	 100��	 �� *Value+�� $
��Data��$	 100��	 �� *Date+�� $��	Kategoria��$	 100��	 �� *
Category+�� $��Data spłaty��$	 100��	 � .&��� 
 �� Path$
 payData��� $

 ----��� $��Osoba��$ 80��	 � .&��� $
 Lender��� $

 ----� � ContextMenu �� .@�m� -   $��Usuń���� $��1��$��2��.+��� -   $��AddIncomButton��$��Dodaj wpływ��$��30��$	��120��$	��Top=�$��10q��� -	   $��AddExpenseButton��$��Dodaj wydatek��$��30��$	��120��$	��Top=�$��10q��� -
   $��AddCreditButton��$��Dodaj pożyczkę��$��30��$	��120��$	��Top=�$��10q�
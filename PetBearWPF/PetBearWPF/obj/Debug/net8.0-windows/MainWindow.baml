   M S B A M L   `   `   `  ����E  APetBearWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PetBearWPF
PetBearWPF  5   	       PetBearWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PetBearWPF     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��600��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
PatCounter��5
      $��Center=�6(   $��0,62,0,0q�6E   $
��Wrap=�6W   $��0 Pats��6k   $	��Top=�6y   $��55��6�   $	��256��6�   $��36(�6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5         ��Name$ TeddyBearImage��5      $��328,155,10,155q�6(   6�   �� 5   
   -   5         ��Name$ UpgradePanel��5       �� Orientation$ Vertical=�6+   $
��Left=�6B   $	��Top=�6]   $	��290��6u   $��
10,155,0,0q�6�   .+�5      �� $'��!Small Pat Upgrade (Cost: 10 Pats)��6   $��16(�6@   �� 5      -   5        $ SmallUpgradeCount��5      $
��Wrap=�63   $��Count: 0��6G   �� 5      -   5         ��Name$ SmallUpgradeButton��5      $	��Buy��61   $��15q�6?    J� RenderTransformOrigin$	 1,0&�6K   $��32��6g   $��55��6s   $
��Left=�6~   6�   �� 5      $(��"Medium Pat Upgrade (Cost: 50 Pats)��6   $��16(�6A   �� 5      -   5        $ MediumUpgradeCount��5      $
��Wrap=�64   $��Count: 0��6H   �� 5      -   5        $ MediumUpgradeButton��5      $	��Buy��62   $��15q�6@   $	 1,0&�6L   $��32��6h   $��55��6t   $
��Left=�6   6�   �� 5      $(��"Large Pat Upgrade (Cost: 200 Pats)��6   $��16(�6A   �� 5      -   5        $ LargeUpgradeCount��5      $
��Wrap=�63   $��Count: 0��6G   �� 5      -	   5        $ LargeUpgradeButton��5      $	��Buy��61   $��15q�6?   $	 1,0&�6K   $��32��6g   $��55��6s   $
��Left=�6~   6�   5      �� 5   
   -
   5        $ Console��5      $��Center=�6%   $��	0,497,0,0q�6B   $
��Wrap=�6U   $	��Top=�6i   $��18(�6�   $	��339��6�   5      5      
   M S B A M L   `   `   `  ����T  PFinalVicenteManuelAngeles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:FinalVicenteManuelAngelesFinalVicenteManuelAngeles  5   	   *    $FinalVicenteManuelAngeles.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:FinalVicenteManuelAngeles     5   	     � Title$
  Home��5   
   $	��329��6   $	��644��6$   .��5	      �� .+�5
   
   �� -   5         ��Name$ btnGetAllProducts��5
      $��Get All Products��6L    �� Left$ 36��6g   
 �� Top$ 36��6x   $��41��6�   $	��101��6�   $
��Bold"�6�   �� 5   
   -   5        $ btnClear��5      $��
Clear Data��6$   $	 160��69   $ 36��6K   $��41��6[   $	��101��6g   $
��Bold"�6s   $
��Left=�6�   $��Center=�6�   6�   �� 5   
   $��Get Products by Category��6   $ 36��63   $ 93��6D   $��33��6T   $	��187��6`   $��Center=�6l   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5         ��Name$ productCombo��5      $��13(�6)   $
��bold"�67   $	��225��6I   $ 36��6U   $	 126��6f   $��32��6w   $
��Left=�6�   $��Center=�6�   6�   �� 5   
   $��Search Products by Name��6   $ 36��63   $	 165��6D   $��33��6U   $	��187��6a   $��Center=�6m   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5         ��Name$ txtsearchProd��5      $ 36��6)    �� TextWrapping$
 Wrap=�6:   $	 198��6N   $	��148��6_   $��26��6k   �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $	 200��65   $	 198��6G    J� RenderTransformOrigin$ 0.158,-0.202&�6X   $��26��6}   $��61��6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ 
btnAddProd��5      $��Add New Product��6%   $ 36��6?   $	 242��6P   $��33��6a   $	��225��6m   $
��Bold"�6y   $��14(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grdProducts��5      $	��239��6(   $	��316��65   $ 36��6A   $	 294��6Q   $��Center=�6c   $	��Top=�6�   5      5      
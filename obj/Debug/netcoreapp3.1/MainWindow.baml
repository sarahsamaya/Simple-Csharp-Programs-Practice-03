   M S B A M L   `   `   `  ����R  NAssLoanAmountCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AssLoanAmountCalculatorAssLoanAmountCalculator  5   	   (    "AssLoanAmountCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:AssLoanAmountCalculator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5        $��myGrid��5	      $	��440��6   $��	0,0,-19,0q�6&   ���	#FFFAF5F5$��Center=�6P   $��Center=�6m   .+�5   
   �� $0��*Loan Calculator - Find the Monthly Payment��6   $
��Wrap=�6F   $��37��6Z   $	��588��6f   $��20(�6r   $
��Left=�6�   $	��Top=�6�   $��Arial Black)�6�   ���	#FF007ACC$��	93,10,0,0q�6�   �� 5   
   -   5        $��Clear��5      $
��Left=�6!   $��
93,241,0,0q�6<   $	��Top=�6P   $��49��6h   $	��206��6t   $��Arial Black)�6�   $��20(�6�   ���	#FFF6E7836�   �� 5   
   -   5        $��	Calculate��5      $
��Left=�6%   $��325,241,0,0q�6@   $	��Top=�6U   $��49��6m   $	��206��6y   $��Arial Black)�6�   $��20(�6�   ���	#FFCAF0996�   �� 5   
   -   5         ��Name$ tblockResult��5      $��78��6*   $��Center=�66   $��-1,0,9,0q�6Q   �� 5   
   -   5         ��Name$ lbError��5      $�� ��6!   $
��Left=�6,   $��
93,293,0,0q�6G   $	��Top=�6[   $	��546��6s   ���	#FFF63030$
��Bold"�6�   �� 5   
   -   5         ��Name$ 	tbIntRate��5      $
��Left=�6&   $��222,115,0,0q�6A   $�� ��6V    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $��Arial Black)�6�   $��16(�6�   $��23��6�   $	��276��6�   6�   �� 5   
   -   5        $ tbNumbMonth��5      $
��Left=�6)   $��222,168,0,0q�6D   $�� ��6Y   $
 Wrap=�6a   $	��Top=�6u   $��Arial Black)�6�   $��16(�6�   $��23��6�   $	��276��6�   6�   �� 5   
   -   5        $ tbLoanAmount��5      $
��Left=�6(   $��
222,61,0,0q�6C   $�� ��6W   $
 Wrap=�6_   $	��Top=�6s   $��Arial Black)�6�   $��16(�6�   $��23��6�   $	��276��6�   6�   �� 5   
   -	   5        $��LbResult��5      $
��Left=�6    $��
93,322,0,0q�6;   $	��Top=�6O   $	��588��6g   $��Arial Black)�6s   $��16(�6�   $
��Bold"�6�   $��74��6�   ���	#FFF2F2F26�   �� 5   
   -
   5        $ lbInterestRat��5      $��Interest Rate % :��6'   $
��Left=�6C   $��118,115,0,0q�6^   $	��Top=�6s   $��31��6�   $��92��6�   �� 5   
   -   5        $ lbLoanAmount��5      $��Loan Amount $ :��6&   $
��Left=�6@   $��
118,61,0,0q�6[   $	��Top=�6o   �� 5   
   -   5        $ lbNumberMonths��5      $��Number of months :��6)   $��
93,168,0,0q�6F   $	��Top=�6Z   $
��Left=�6r   $	��117��6�   5      5      
   M S B A M L   `   `   `  ����?  ;Quiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QuizQuiz  5   	       Quiz.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Quiz     5   	   -   5          � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)   .��5
      � $��Right=�6   $	��517��6'   $��0,0,0,0q�63    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $
��244* �6   �� 5      $	��25* �6   .+�5   
   �� -   5        $��sp_question��5      $
��Left=�6(   $	��230��6C   $��30,9,0,0q�6P   $��1��6b   $	��Top=�6o   $	��453��6�   .+�5      �� -   5         ��Name$ tb_question��5      $��50��6-   $
��Wrap=�69   ��6M   �� *
question+6i   �� 5      -   5         ��Name$ 	lb_answer��5      $
��Left=�6)   $��0,5,0,0q�6D    �� DisplayMemberPath$ answer��6u   $��75��6�   $	��450��6�   ��6U   �� *	answers+6�   5      �� 5   
   -   5         ��Name$ btn_ok��5      $��OK��6!   $��Center=�6.   $��222,3,220,0q�6K   $��2��6`   $	��Top=�6m   $��75��6�   6�   5   	   5      
   M S B A M L   `   `   `  ����?  ;ToGo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ToGoToGo  5   	       ToGo.Payment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:ToGo     5   	     � Title$  Payment��5   	   $��454.027��6   $��811.073��6*    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� ���	#FF5785B4$��67��6%   $��
0,24,-11,0q�61    �� RadiusY$ 12��6E    �� RadiusX$ 12��6R   ���	#FFFDF9F9$��14��6r   $	��Top=�6�   �� 5   
    �� CornerRadius$ 10��6   $��Center=�6$   $��472,308,37,15q�6A   $��Center=�6X   $��88��6s   $��40��6~   $��1��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF44E470��6#    � Offset$ 0Q�65   � 5      $ 	#FF37AE68��6#   $ 1Q�65   5      ._�5      �� -   5        $��結帳��5      $��15(�6"   
�������$��Right=�6�   $��88��6�   ��60   Z� ��6G   Z� 6�   5      �� 5   
   $ 10��6   $��Center=�6$   $��363,308,146,15q�6A   $��Center=�6Y   $��88��6t   $��40��6   $��1��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF97C3F7��6#   $ 0Q�65   � 5      $ 	#FF5B9BE8��6#   $ 1Q�65   5      ._�5      �� -   5        $��取消��5      $��15(�6"   
���������60   Z� ��6G   Z� 6p   5      �� 5   
   $��141,76,81,104q�6   $��Center=�6(   $��Center=�6E   $	��183��6`   $	��375��6m   $��1��6y   .+�5       �� $��卡號��6   $��16(�6!   $
��Left=�6/   $	��Top=�6J   $��26��6b   $��46��6n   	 �� Left$		 168��6y   

 �� Top$
 44��6�   �� 5!      $��	安全碼��6   $��16(�6"   $
��Left=�60   $	��Top=�6K   $��37��6c   $��80��6o   $		 168��6z   $	
 113��6�    J� RenderTransformOrigin$ 	0.6,0.604&�6�   �� 5"      $��有效期至(mm/yy)��6   $��16(�6*   $
��Left=�68   $	��Top=�6S   $��37��6k   $	��136��6w   $	
 113��6�   $ 1,0.568&�6�   $	 10��6�   �� 5#      -   5        $��TxtCardNumber��5#      $
��Left=�6+   $��24��6F    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��189��6�   $
 84��6�   $		 168��6�   �� 5$      -   5        $��ExpireMounth��5$      $
��Left=�6*   $��27��6F   $
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $��43��6�   $	
 152��6�   $	 17��6�   G� 5%      -   5        $��
SecurityNo��5%      $		 168��6,   $	
 159��6>   $��24��6O   $��58��6[   �� 5&      $��持卡人姓名 ��6   $��16(�6%   $
��Left=�63   $	��Top=�6N   $��27��6f   $	��100��6r   $	 10��6~   $
 43��6�   �� 5'      -   5         ��Name$ TxtName��5'      $
��Left=�6'   $��24��6B   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��107��6�   $
 84��6�   $	 10��6�   �� 5(      $��/��6   $��16(�6    $
��Left=�6.   $	��Top=�6I   $��29��6a   $��19��6m   $	 64��6x   $	
 150��6�   $ 0.263,0.621&�6�   �� 5)      -   5        $��
ExpireYear��5)      $
��Left=�6(   $��27��6D   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $��45��6�   $	
 152��6�   $	 83��6�   5*      �� 5+   
   $��Center=�6   $��41��6-   $��10,37,699,341q�69   $��Center=�6P   $��83��6k   $��Image/credit-card.png��6v   �� 5,   
   ���	#7FB7D0EA$��Center=�6%   $��62��6B   $ 11.544��6N   $ 11.544��6_   $��14��6p   $��Center=�6�   $	��218��6�   $��26,295,548,62q�6�   $ 0.5,0.5&�6�   z�5-      V� 5.      .~�5/      �� �� 50       �� AngleX$ 20.803Q�6$   �� 51      T� 52       T� X$ -17.287Q�6)   53      55      �� 56   
   $��Center=�6   $��54��6-   $��Center=�69   $��60��6T   $��Image/visa.png��6_   $��34,300,698,65q�6w   �� 57   
   $��Center=�6   $��54��6-   $��Center=�69   $��66��6T   $��Image/mastercard.png��6_   $��94,300,632,65q�6}   �� 58   
   $��Center=�6   $��39��6-   $��Center=�69   $��42��6T   $ ��Image/american-express.png��6_   $ 0.597,0.903&�6�   $��165,308,585,72q�6�   59      5:      
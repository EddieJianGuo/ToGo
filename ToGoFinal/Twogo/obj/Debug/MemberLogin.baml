   M S B A M L   `   `   `  ����?  ;ToGo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ToGoToGo  5   	       ToGo.MemberLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:ToGo     5   	   -   5          � WindowStyle$
  None=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � Title$ CMLogin��5   	   $	��500��6   $��714.8��6&    � 	Resources 5         
windowDown �� 
TargetName �� TargetProperty W� From	 W� To	 g� Duration��%�   &	        �� 5   
   .��5      W� $ translateTransform1��6   $ Y�6J   $	 -70X�6h   $ 0X�6s   $	 0:0:0.3D�6z   6�   5      5      .��5      � $��-1,-2,0.6,2q�6   
 J� RenderTransformOrigin$
 0.5,0.5&�6    z�5   
   V� 5      .~�5      T� -   5        translateTransform1��5   %   5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5        $��
rectangle1��5      ���	#FFE8E8E8$
��Left=�67   $	��400��6R   $��	40,89,0,0q�6_   ���	#FFFDF9F9$	��Top=�6�   $	��619��6�   $��14��6�    �� RadiusY$ 16��6�    �� RadiusX$ 16��6�   $
 0.5,0.5&�6�   6�   �� 5   
   $��E-mail��6   $
��Left=�6!   $��111,133,0,0q�6<   $	��Top=�6Q   $	��107��6i   $��Tahoma)�6u   $��20(�6�   �� 5   
   -   5        $��UsernameTextBox��5   2   $��zj4ru04eji6@yahoo.com.tw��6   $
��Left=�6I   $��24��6d   $��111,166,0,0q�6p    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��209��6�   �� 5   
   $��Password��6   $
��Left=�6#   $��111,207,0,0q�6>   $	��Top=�6S    J� Opacity$ 0.995Q�6k   $��Tahoma)�6{   $��20(�6�   $
 0.5,0.5&�6�   G� 5    
   -   5        $��PasswordTextBox��5    (    G� Password$ 801231��6   $��24��6?   $	��210��6K   $
��Left=�6W   $��111,241,0,0q�6r   $	��Top=�6�   �� 5!   
   $
��Left=�6   $��40��6+   $��127,365,0,0q�67   $	��Top=�6L   $��48��6d   $ ��Image/Google-Plus-icon.png��6o   �� 5"   
   $
��Left=�6   $��40��6+   $��194,365,0,0q�67   $	��Top=�6L   $��47��6d   $��Image/Facebook-icon.png��6o   �� 5#   
   $
��Left=�6   $��40��6+   $��260,365,0,0q�67   $	��Top=�6L   $��48��6d   $��Image/Twitter-icon.png��6o   $
 
0.842,0.51&�6�   �� 5$   
   -   5        ���	#FFA1AAFF
�������$��登入��5$   ;   $��Tahoma)�6H   $��0q�6\   $
��Left=�6p   $��127,312,0,0q�6�   $	��Top=�6�   $	��170��6�   $��30��6�   $��14(�6�   �� 5%   
   -   5        $��Button��5%      $
��Left=�6#   $��
659,56,0,0q�6>   $	��Top=�6R   $��33��6j   $��33��6�   ��6u   Z� ��6�   Z� ��5&      �� 5'       �� ImageSource$R LImage/Danieledesantis-Playstation-Flat-Playstation-cross-black-and-white.ico��6   5)      �� 5*   
   $��Image/global.png��6   $
��Left=�6*   $	��165��6E   $��403,188,0,0q�6R   $	��Top=�6g   $	��202��6   �� 5+   
   $-��'登入後可以獲得更多優惠喲！��6   $
��Left=�6(   $��387,376,0,0q�6C   $	��Top=�6X   $��16(�6p   $��	Agency FB)�6~   ���	#FF5954546�   �� 5,   
   -   5        $9��3我是新朋友？點這裡加入貳行大家庭！��5,      
������ 
����  �$��0q�6\   $
��Left=�6p   $��125,430,0,0q�6�   $	��Top=�6�   $	��200��6�   6�   �� 5-   
   -	   5        $��忘記密碼��5-      
������ 
����  �$��0q�6O   $
��Left=�6c   $��271,270,0,0q�6~   $	��Top=�6�   6�   �� 5.   
   -
   5        $��
EmailLabel��5.   /   
���  ��$��16(�6!   $
��Left=�6A   $��240,135,0,0q�6\   $	��Top=�6q   50      51      
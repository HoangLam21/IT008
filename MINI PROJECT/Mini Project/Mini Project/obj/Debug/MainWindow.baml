   M S B A M L   `   `   `  ����G  CMini Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Mini_ProjectMini_Project  5   	       Mini_Project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:Mini_Project  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ 
MainWindow��5
   	   $	��650��6   $	��450��6)    � WindowStyle$
 None=�65    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	   .��5      �� ���#F0FFF0._�5   
   � .+�5      �� -   5        $��Right=�5      $	��Top=�61   $��0,3,38,0q�6I   ���#F0FFF0
������ $��28��6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6.   
���   �$��24��6W   $��24��6c   $��0,0,8,0q�6n   5      5      �� 5      -   5        $��Right=�5      $	��Top=�61   $��0,3,10,0q�6I   ���#F0FFF0
������ .��5      �� $ 
Horizontal=�6   .+�5        $ 
CloseThick=�6.   
���   �$��24��6S   $��24��6_   5      5      � 5      $��Center=�6   $��Center=�6.   .+�5      � $	��450��6   $	��350��6$    � RowDefinitions 5      �� 5      $	��197 �6(   67   �� 5      6*   .+�5       � $��0��6   .+�5!      �� $��Center=�6%   $	��Top=�6B   $��0,80,0,0q�6Z   .+�5"      ��  �� TextAlignment$
 Left=�6(   $��30(�6=   ���#7CCD7C$
��Bold"�6a   $	��350��6s   Chào mừng bạn6�   �� 5#      $ Right=�6(   $��30(�6>   ���#7CCD7C$
��Bold"�6a   $	��350��6s   $��đến với TicketBox��6   5$      5%      � 5'      $��1��6   .+�5(      �� $��	0,30,0,10q�6%   .+�5)      �� -   5        	 ��Name$
	 Demo��50   T   $��
DEMO EVENT��5)   %   
 �� 	IsDefault
 . $��47��5+   !   $	��333��5,   !   ���#7CCD7C
���   �$
��Bold"�5/   !   
������ ��51   "   �� 52   &    �� 
TargetType" ��66   .R�53   *   �� #��z��61   #��z��54   -   #��z��55   -    �� CornerRadius$ 24��56   -   ._�57   .   �� $��Center=�6?   $��Center=�6\   58   +   59   '   5;      �� 5<      -   5        $	 	Realities��5C   M   $��REALITITIES��5<   %   
 . $��47��5>   !   $	��333��5?   !   ���#7CCD7C
���   �$
��Bold"�5B   !   
������ $��0,20,0,0q�5C   ;   ��5D   "   �� 5E   &   " ��66   .R�5F   *   �� #��z��61   #��z��5G   -   #��z��5H   -   $ 24��5I   -   ._�5J   .   �� $��Center=�6?   $��Center=�6\   5K   +   5L   '   5N      � 5O      $��Center=�6#   $��Center=�6>   $	��250��6[   5P      5Q      5R      5S      5T      5U      5V      
   M S B A M L   `   `   `  ����F  BWPF Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_ProjectWPF_Project  5   	       WPF_Project.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF_Project     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1080��6)    � 	Resources 5
         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 70Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5       � ���	#FFDEDEDE.+�5!   
   � -   5        	 �Name$	 GridMain��5!      $��Right=�6!   $��Bottom=�6=   $	��540��6X   $
��1010��6e   � 5"   
   $��60��6   $	��Top=�6   ���	#FF5C99D6
 J� Effect
 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�5&      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5'      �� $��Lahiru Damian��6   $��Center=�61   $��16(�6L   '  !MaterialDesignThemes.Wpf.PopupBox  5(         PlacementMode$ BottomAndAlignRightEdges=�6*      	StaysOpen$ False��6S   $��10q�6e      PopupContent. 5)      �� $	��150��6!   .+�5*      �� $��Settings��6!   �� 5+      $��Account��6!   �� 5,      $
��Help��6!   �� 5-      �� 5.      -   5        $��LogoutButton��5.   2   $��Logout��6!   62   5/      50      51      �� 52      $��Center=�6   $��Center=�65   $��22(�6P   My Home Doctor6n   53      � 54   
   -   5        $	 GridMenu��54      $��70��6!   $
��Left=�6,   ���	#FF31577E
 55        56      $ 2Q�6#   $ 1Q�62   $ 	#FFAEAEAE��6B   .+�58      �� .+�59      � $	��150��6   
������� J� RenderTransformOrigin$ 0.5,0.5&�67   z�5:      V� 5;      .~�5<      �� �� 5=      �� 5>      T� 5?      5@      .+�5B      �� -   5         ��Name$ ButtonOpenMenu��5B      $��60��65   $��60��6A   $��5q�6L   $��Right=�6W   $	��Top=�6s    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5C      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�62   $��25��6>   $��25��6I   5D      �� 5E      -   5        $ ButtonCloseMenu��5E      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5F        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5G      �� 5I      $��80��6   $��Bottom=�6(   5J      �� 5K      -   5         ��Name$ ListViewMenu��5K      ���	#FF5C99D6$��Disabled=�6H   .@�5L      �� -   5         ��Name$ ItemHome��5L   #   $��60��65   .��5M      �� $ 
Horizontal=�6%   .+�5N        $ ViewDashboard=�66   $��25��6K   $��25��6W   $��10q�6b   �� 5O      $
��Home��6(   $��Center=�64   $��20 10q�6O   5P      5Q      �� 5R      -   5        $ 
ItemCreate��5R   #   $��60��67   .��5S      �� $ 
Horizontal=�6%   .+�5T        $ Pencil=�66   $��25��6D   $��25��6P   $��10q�6[   �� 5U      $��Create��6(   $��Center=�66   $��20 10q�6Q   5V      5W      �� 5X      -	   5        $ ItemBook��5X   #   $��60��65   .��5Y      �� $ 
Horizontal=�6%   .+�5Z        $
 Book=�66   $��25��6B   $��25��6N   $��10q�6Y   �� 5[      $��Booking��6(   $��Center=�67   $��20 10q�6S   5\      5]      �� 5^      -
   5        $ ItemComment��5^   #   $��60��68   .��5_      �� $ 
Horizontal=�6%   .+�5`        $ Comment=�66   $��25��6E   $��25��6Q   $��10q�6\   �� 5a      $��Comment��6(   $��Center=�67   $��20 10q�6S   5b      5c      5d      5e      5f      5g      5h      
   M S B A M L   `   `   `  ����F  BWPF Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_ProjectWPF_Project  5      *    $WPF_Project.UserControlPatientSearch   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WPF_Project     5      .��5	      � 
�������$��-210,-90,0,0q�6"     � RowDefinitions  5
   
   �� 5      $
��271* �6   �� 5      $
��269* �6   .+�5   
   �� -   5        $��EmailBox��5      $
��Left=�6"   $��	310,9,0,0q�6=    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��148��6|   $��Enter the patient email��6�   $��1��6�   �� 5   
   $
��Left=�6   $��306,227,0,0q�6+   $	��Top=�6@   �� 5   
   -   5         ��Name$ FirstNameBox��5      $
��Name��6&   $
��Left=�65   $��
310,67,0,0q�6P   $	��Top=�6d    J� RenderTransformOrigin$ 6.126,3.155&�6|   $��1��6�   �� 5   
   -   5        $ IDBox��5      $��ID��6   $
��Left=�6,   $��
477,67,0,0q�6G   $	��Top=�6[   $ 0.681,-1.085&�6s   $��1��6�   �� 5   
   -   5        $ LastNameBox��5      $��Label��6%   $
��Left=�65   $��314,116,0,0q�6P   $	��Top=�6e   $ 0.445,0.814&�6}   $��1��6�   �� 5   
   -   5        $ 
PhoneNoBox��5      $��Phone No��6$   $
��Left=�67   $��
594,67,0,0q�6R   $	��Top=�6f   $ 0.674,0.696&�6~   $��1��6�   �� 5   
   -   5        $ 
AddressBox��5      $
��Left=�6$   $��
359,17,0,0q�6?   $	��Top=�6S   $��1��6k   �� 5   
   -   5        $ ConditionBox��5      $��Label��6&   $
��Left=�66   $��469,116,0,0q�6Q   $	��Top=�6f   $ 
0.267,0.33&�6~   $��1��6�   �� 5   
   -   5        $
��Find��5   &   $
��Left=�65   $��	485,3,0,0q�6P   $	��Top=�6c   $ 0.405,0.684&�6{   $��1��6�   �� 5   
   -	   5        $��	NewValues��5      $
��Left=�6#   $��
780,57,0,0q�6>   $0��*Enter the latest condition of the patient ��6R   $
 Wrap=�6�   $	��Top=�6�   $	��176��6�   $��83��6�   $��1��6�   �� 5   
   -
   5        $��Save Cahnges��5      $
��Left=�6(   $��780,166,0,71q�6C   $��1��6p   �� 5   
   $	��115��6   $��306,133,35,0q�6!   $p��jEnter patient email to receive the patient details in order to update the current condition of the patient��67    �� TextAlignment$ Center=�6�   $��30(�6�   $
��Wrap=�6�   $	��Top=�6�   5      5      
   M S B A M L   `   `   `  ����"  Zaneuski.Casino.WpfApplication/    )Zaneuski.Casino.WpfApplication.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $��514.5��6   $
��1000��6+   .��5      � $��10,30,30,12q�6   .+�5   
   �� $��Login��6   $
��Left=�6    $��
367,10,0,0q�6;   $	��Top=�6O    J� RenderTransformOrigin$ 6.108,-2.423&�6g   �� 5   
   $��Password��6   $
��Left=�6#   $��
567,10,0,0q�6>   $	��Top=�6R   �� 5   
   $
��Left=�6   $��23��6-   $��
433,12,0,0q�69    �� TextWrapping$
 Wrap=�6M   $��enter login��6a   $	��Top=�6t   $	��120��6�   �� 5	   
   $
��Left=�6   $��23��6-   $��
641,12,0,0q�69   $
 Wrap=�6M   $��enter password��6a   $	��Top=�6w   $	��120��6�   �� 5
   
   -   5        $��Log in��5
      $
��Left=�6"   $��
367,41,0,0q�6=   $	��Top=�6Q   $	��186��6i   6u   �� 5   
   -   5        $��Sign Up��5      $
��Left=�6#   $��
576,40,0,0q�6>   $	��Top=�6R   $	��185��6j   6v   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ TournamentsView��5      $
��Left=�6,   $��20,119,0,-196q�6G   $	��Top=�6^   $	��310��6v   $	��920��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6%      Header$ Tournament name��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *TournamentName+5        5      $	 100 6%   $ GameType��62    6D   �� *
GameType+5        5      $	 200 6%   $ Minimum Number Of Wins��62    6R   �� *MinimumNumberOfWins+5        5      $ 80 6%   $	 Fee��61    6>   �� *Fee+5        5      $	 130 6%   $ Number of Rounds��62    6L   �� *NumbefOfRound+5         5"      $	 150 6%   $ Number Of Participants��62    6R   �� *NumberOfParticipants+5$        5&      $	 130 6%   $ Admin��62    6A   �� *Admin+5(      5*      �� 5+   
   -   5        $��Players Rating��5+      $
��Left=�6*   $��	37,14,0,0q�6E   $	��Top=�6X   $	��150��6p   6|   5,      5-      
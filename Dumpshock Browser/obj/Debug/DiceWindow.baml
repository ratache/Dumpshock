   M S B A M L   `   `   `  ����L  HDumpshock Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Dumpshock_BrowserDumpshock_Browser  5   	   "    Dumpshock_Browser.DiceWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Dumpshock_Browser     5   	     � Title$  
DiceWindow��5   	   $��399.115��6   $	��800��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ sld_dice��5
      $
��Left=�6#   $��
84,232,0,0q�6>   $	��Top=�6R   $	��183��6j    �� IsSnapToTickEnabled .  � SmallChange$ 1Q�6�    � Maximum$ 30Q�6�    � Minimum$ 1Q�6�   �� 5   
   -   5         ��Name$ lbl_diceSize��5      $
��Left=�6�   $��279,226,0,0q�6�   $	��Top=�6�   $��Arial)�6�   $��20(�6�   $��Italic$�6�   $
��Bold"�6�   ��6&   ��  �� ElementName$ sld_dice�� �� Path$ Value�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5   
   -   5        $ sld_diff��5      $
��Left=�6#   $��
84,270,0,0q�6>   $	��Top=�6R   
 J� RenderTransformOrigin$
 0.456,0.453&�6j   $	��183��6�   $ 20Q�6�   $ 1Q�6�   $ 1Q�6�    . 6�   �� 5   
   -   5        $ lbl_Diff��5      $
��Left=�6|   $��279,264,0,0q�6�   $	��Top=�6�   $��Arial)�6�   $��20(�6�   $��Italic$�6�   $
��Bold"�6�   ��6"   �� $ sld_diff��$ Value�$	 PropertyChanged=�6�   �� 5   
   -   5        $ lbl_txtDice��5      $
��DICE��6%   $
��Left=�64   $��
20,226,0,0q�6O   $	��Top=�6c   $��Arial)�6{   $
��Bold"�6�   $��Italic$�6�   $��20(�6�   �� 5   
   -   5        $ lbl_txtDiff��5      $
��DIFF��6%   $
��Left=�64   $��
20,264,0,0q�6O   $	��Top=�6c   $��Arial)�6{   $��20(�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ btn_Quit��5      $
��Exit��6#   $
��Left=�62   $��707,336,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ btn_Roll��5      $
��Roll��6#   $
��Left=�62   $��327,226,0,0q�6M   $	��Top=�6b   $��75��6z   $��75��6�   6�   �� 5   
   -	   5        $ lbl_txtSuccs��5      $��	Successes��6&   $
��Left=�6:   $��421,232,0,0q�6U   $	��Top=�6j   �� 5   
   -
   5        $ lbl_txtGlitches��5      $��Glitches��6)   $
��Left=�6<   $��421,269,0,0q�6W   $	��Top=�6l   �� 5   
   -   5        $ lbl_Successes��5      $��0��6'   $
��Left=�63   $��497,232,0,0q�6N   $	��Top=�6c   �� 5   
   -   5        $ lbl_Glitches��5      $��0��6&   $
��Left=�62   $��497,269,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ 
lbl_Output��5      $��Label��6$   $
��Left=�64   $��
40,134,0,0q�6O   $	��Top=�6c   5      5      
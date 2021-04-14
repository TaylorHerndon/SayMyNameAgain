Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Say My Name... Again
'https://github.com/TaylorHerndon/SayMyNameAgain

Module SayMyNameAgain

    Sub Main()

        Dim name As String = ""
        Dim restart As Boolean = False

        Console.WindowHeight = Console.LargestWindowHeight
        Console.WindowWidth = Console.LargestWindowWidth
        Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight)
        Console.SetWindowPosition(0, 0)

        Do Until restart = False

            'Ask for the user's name
            Console.Clear()
            Console.WriteLine("Oi, ello again!")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("I think I've done forgot yer name ehh")
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine("What was it again?")

            name = Console.ReadLine()
            Console.Clear()

            Select Case name 'Select a dialog based on the user's name

                Case "Emily" 'Dialog if the user's name is Emily

                    restart = False 'Allow the user to continue

                    Console.WriteLine("Oi, ello again emily!")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Been such a long time I hardley reconized ya!")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("So, ow are you an yer family doing?")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Oi don't bother... ow bout me and you make a painting huh?")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Press any key to start painting...")
                    Console.ReadKey()

                Case "Joe" 'Dialog if the user's name is Joe

                    restart = False 'Allow the user to continue

                    Console.WriteLine("Oi, Joe!")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Ow en the world did I not reconize ye?")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("I spose I'm really losing it in me old age.")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Oi, I know! Ow bout me and you head out painting?")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("No, we won't be tagging any omes this time round.")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Well just get ourselves a canvas an paint oer a beer!")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("What do ye say?")
                    System.Threading.Thread.Sleep(1500)
                    Console.WriteLine("Press any key to start painting...")
                    Console.ReadKey()

                Case "Taylor" 'Dialog if the user's name is Taylor

                    restart = False 'Allow the user to continue

                    Console.WriteLine("Oi, Taylor ye say?")
                    System.Threading.Thread.Sleep(1500)
                    Console.WriteLine("Aren't ye the poor bloke who made this dinky program?")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Quite bland to be honest...")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Could use a wee bit of art on the walls.")
                    System.Threading.Thread.Sleep(1500)
                    Console.WriteLine("How bout that, eh?")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Press any key to start painting...")
                    Console.ReadKey()

                Case Else 'If any other name is used then give a short dialog and allow the user to restart.

                    restart = True 'Ask for the user's name again

                    Console.WriteLine("Eh? No, no, I don't know ye. Run along now.")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Ye can head on outa ere now.")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Press any key to return to the start...")
                    Console.ReadKey()

            End Select

        Loop

        'Draw some Ascii art because it is cool :)
        Console.Clear()
        Console.WriteLine(",                                                                                                                                                                                            ,(//(*((*(/
,                                                                                                                                                                                            .#((//(/#*(
,                                                                                                                                                                                             ##(((/%%(%
,                                                                                                                                                                                             *(%((#((((
,                                                                        ..                                                                                                                    %&(%#%(##
,                                                                  #&*,*. .  .,.,/#,                                                                                                           #&#(((#&&
,                                                               *%/., .   .. ..  .. .(#/.                                                                                                      (###%##&%
,                                                              # *..   .              .*,@@.                                                                                                   /@&%&@%%%
,                                                             @#.    #@@,#                 ,#(%#/(//(,,.                                                                                       ,##%%&#%%
,                                                            /,/     //((.                %/  ,       .*..,(###%(*.                                                                            .&%%%&%(&
,                                                            (*, .,,                    .&, ..   .      .           .(%#,                                                                       @@%####%
,                                                          (@%,..                      /*.,.   .        . .               .(/*                                                                  (@@%%%##
,                                                        /@%,, (*   ..                *//. .     .   ,..                      .//.                                                              .@%%###(
,                                                      .@&*.#(  ,#/(,  ...*,..       .(,..  . ..    .                             .*,.                                                           &@%(##%
,                                                     .#.%%/&(     .(&&/ .,. .       (/..    .    . .                                .**.                                                        %@%(##(
,                                                     ..                %@..#, .     %,. .. .  ...  .                                    ,*                                                      (@%(/*/
,                                                                         %&  .      (.. .  . . . .     .     .                        ./   ,,                                                   *@&*,..
,                                                                           (%  *.    &.   . .   ..                            .    .,,      . *,                                                .@@#  .
,                                                                            (&,./,    ( .     ,   ....                      ,,                  .(.                                              @@&. .
,                                                                             *@ . ,,   (. ..    .     *.                              * ,      ,.  ,/                                            #@@, .
,                                                                              /@*     ,..(  .                       ..,,,,        .*/*,((    .  *     /.                                         .@@/ .
,                                                                               .&(&*      ,(. ..                .               *   ..    .,*(/.    ,. ..                                         @@( .
,                                                                                 #@#%,       @%     ..         ./       (        @.         *&(.#@&@&/   *%(                                      %@% .
,                                                                                  *@(*#(        ./@&,.  . .         /&#/.  ,**,.,    ,(**&#/*,.         ..,,  ,//*                                (@& .
,                                                                                    .(#%(#/.         ,(&@@&(/*. .,...,*,//*(#&#%%(/*..          ..               .,,.,,.                          /@@,.
,                                                                                       .(&(/%.                ,,(/*,,...   .,,/**,,,.... .. .,             .     . .   .*(**.                     .@@#.
,                                    /                                                      ./*(**                                              *. ..        ..             . ,((*,.                @@&.
,                                     .%   ,@*                                                   *(* ..                                         .        ...,,.     ..      ...    ../**.           /@@(
,                                      */* &    ,                                                     ,(%%((//*/*..        .. ./((##%%#%(((*/,,,,,..  .  .. .      ..**,...,....      ,   ,,.       .@@%
,                                  *,   #%,#   %.                                                            .*.   @. . ,,.,,,,,. . .,,/(&@@@(,.   ./(#(,.., .      ..    ,    .,,.,,..  .     *.    #@@
,                                   ,*,#**(#  @* /                                                             #&, .@@*                      ..*#/@&&**.     .,*,*,,/,,.     ....                ,,  /@@
,                                     */. #%./@ ,#                                                              #@,  .@#                            .*/(#&%(/,. .     .,*.,..   ....                 .@@
,                                          ,&#&,%#   (*                                                          ,@*  /&#                                    .,,((&%#*,.     ......           .*      %@
,..                            .              /%(( #@.                                            ./@/*,/(%#/,.*(%#@@,.&(&/((#&&@@@&@%#%#/(,                          ...%@&//,        .,       #     .@
,..       .                     ,#,  (/      #%&(/.&                                    .((&@@&&%(****,.   .  #&@@&   &&  /,  ,     ,,//*/*/&#%*(((((#/(#*(/*.                .,*/%&#,         (*      &
,                           ,(&,. *.(..&&%((.      //,                         .*(&&%%(/*   ..            #%, *&.(*. #**#.....,.                .,.*,,*/*/#/*,,,,*.(%(,,*..           .*/%/***,(.      (
,                              /&*&*,/ #*    *@%*   .. /                .*#@&#,,                ...,/#@@@@&@@&&%(/.*#(*#(#(/(/*#/(/*(%&@%@@@@&/(,/**./((*.  ,,.   ,**,,**.**/#&#,.                     ,
,       ..                   #@@(.%#@.  .*@(  ./#(.##.   .,(&%%#&@@@@(,*(*.           ..*#%@@@@@@&,                                              ,*/@%#&%,..   ,(/(***.   ..       ./((*.              .
*                                *&.   ,&@@@@/*#%(.      ./(%&(*.//*       .    */&&@@@@&(,.                                                                 .,/#&&#*      .,,.            ,(((*       .
*               . ...                               .(@@&/**/*.  .,.. . .,/#@@@&%#..                                                                              ..*/##@%##,                    ,/**. .
,                      .                        .%@&#,/.  ... **,../@@@%/*..                                                                                                .../#*,*.                 .*
,                            .              /@@@@/,  * **. ,&@@@@(..                                                                                                                 .*///,            .
,                                  .   .,(@@&#*    ,#@&@@%#,                    .                                                                                                          ..,(/*,.    .
,   .                                         **&@@@&(.                           ..                                                                                                               .,(#(
,                                            .@(.                                                                                                                                                      .")


        Console.ReadKey() 'Wait for user input to continue

    End Sub

End Module

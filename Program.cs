
// Variables
string menu1;
string menu2;
// Variables para cortar loops
bool programa=false ;
bool valido = false;
bool valido1 = false;


// Code

while (!programa)
{   
    // Loop para cuando se tengan las dos entradas verdaderas se acabe el programa
    Console.WriteLine("Bienvenido al menú, escoge la opción que desees");
    Console.WriteLine("a) Animals\nb) Video Games\nc) Vehicles\nd) Weapons\ne) Logos ");
    //Menu de opciones
    menu1 = Console.ReadLine();

    // Loop para seguir el programa hasta que el valor solicitado sea correcto

    while (!valido)
    {
        // Switch de los 5 temas de imagenes en la que cada caso tiene 3 opciones más para escoger tus imagenes
        switch (menu1)
        {
            case "a":

                // dentro de cada caso si se escoge el correcto, se cambia el valor de valido para true
                valido = true;
                while (!valido1)
                {
                    Console.WriteLine("Escoge una opción para el Animals:");
                    Console.WriteLine("a) Amoeba \nb) Cat \nc) Beaver");

                    menu2 = Console.ReadLine();

                    switch (menu2)
                    {
                        // dentro de cada caso si se escoge el correcto, se cambia el valor de valido1 para true
                        case "a":
                            Console.Clear();

                            Console.WriteLine("             ,,,,,,,,\r\n           ,|||````||||\r\n     ,,,,|||||       ||,\r\n  ,||||```````       `||\r\n,|||`                 |||,\r\n||`     ....,          `|||\r\n||     ::::::::          |||,\r\n||     :::::::'     ||    ``|||,\r\n||,     :::::'               `|||\r\n`||,                           |||\r\n `|||,       ||          ||    ,||\r\n   `||                        |||`\r\n    ||                   ,,,||||\r\n    ||              ,||||||```\r\n   ,||         ,,|||||`\r\n  ,||`   ||   |||`\r\n |||`         ||\r\n,||           ||\r\n||`           ||\r\n|||,         |||\r\n `|||,,    ,|||\r\n   ``||||||||`");
                            valido1 = true;
                            break;
                        case "b":
                            Console.Clear();

                            Console.WriteLine(" _._     _,-'\"\"`-._\r\n(,-.`._,'(       |\\`-/|\r\n    `-.-' \\ )-`( , o o)\r\n          `-    \\`_`\"'-");
                            valido1 = true;
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("                   |    :|\r\n                   |     |\r\n                   |    .|\r\n               ____|    .|\r\n             .' .  ).   ,'\r\n           .' c   '7 ) (\r\n       _.-\"       |.'   `.\r\n     .'           \"8E   :|\r\n     |          _}\"\"    :|\r\n     |         (   |     |\r\n    .'         )   |    :|\r\n.odCG8o_.---.__8E  |    .|    \r\n`Y8MMP\"\"       \"\"  `-...-'   cgmm");
                            valido1 = true;
                            break;
                        
                        // Repetir loop hasta conseguir entrada valida
                        default:
                            Console.Clear();

                            Console.WriteLine("Escoge una opción válida");
                            break;
                    }
                }
                break;
            case "b":
                valido = true;

                while (!valido1)
                {
                    Console.WriteLine("Escoge una opción para Video Games:");
                    Console.WriteLine("a) Sonic\nb) Link \nc) PacMan");

                    menu2 = Console.ReadLine();

                    switch (menu2)
                    {
                        case "a":
                            Console.Clear();

                            Console.WriteLine("                             ...,?77??!~~~~!???77?<~.... \r\n                        ..?7`                           `7!.. \r\n                    .,=`          ..~7^`   I                  ?1. \r\n       ........  ..^            ?`  ..?7!1 .               ...??7 \r\n      .        .7`        .,777.. .I.    . .!          .,7! \r\n      ..     .?         .^      .l   ?i. . .`       .,^ \r\n       b    .!        .= .?7???7~.     .>r .      .= \r\n       .,.?4         , .^         1        `     4... \r\n        J   ^         ,            5       `         ?<. \r\n       .%.7;         .`     .,     .;                   .=. \r\n       .+^ .,       .%      MML     F       .,             ?, \r\n        P   ,,      J      .MMN     F        6               4. \r\n        l    d,    ,       .MMM!   .t        ..               ,, \r\n        ,    JMa..`         MMM`   .         .!                .; \r\n         r   .M#            .M#   .%  .      .~                 ., \r\n       dMMMNJ..!                 .P7!  .>    .         .         ,, \r\n       .WMMMMMm  ?^..       ..,?! ..    ..   ,  Z7`        `?^..  ,, \r\n          ?THB3       ?77?!        .Yr  .   .!   ?,              ?^C \r\n            ?,                   .,^.` .%  .^      5. \r\n              7,          .....?7     .^  ,`        ?. \r\n                `<.                 .= .`'           1 \r\n                ....dn... ... ...,7..J=!7,           ., \r\n             ..=     G.,7  ..,o..  .?    J.           F \r\n           .J.  .^ ,,,t  ,^        ?^.  .^  `?~.      F \r\n          r %J. $    5r J             ,r.1      .=.  .% \r\n          r .77=?4.    ``,     l ., 1  .. <.       4., \r\n          .$..    .X..   .n..  ., J. r .`  J.       `' \r\n        .?`  .5        `` .%   .% .' L.'    t \r\n        ,. ..1JL          .,   J .$.?`      . \r\n                1.          .=` ` .J7??7<.. .; \r\n                 JS..    ..^      L        7.: \r\n                   `> ..       J.  4. \r\n                    +   r `t   r ~=..G. \r\n                    =   $  ,.  J \r\n                    2   r   t  .; \r\n              .,7!  r   t`7~..  j.. \r\n              j   7~L...$=.?7r   r ;?1. \r\n               8.      .=    j ..,^   .. \r\n              r        G              . \r\n            .,7,        j,           .>=. \r\n         .J??,  `T....... %             .. \r\n      ..^     <.  ~.    ,.             .D \r\n    .?`        1   L     .7.........?Ti..l \r\n   ,`           L  .    .%    .`!       `j, \r\n .^             .  ..   .`   .^  .?7!?7+. 1 \r\n.`              .  .`..`7.  .^  ,`      .i.; \r\n.7<..........~<<3?7!`    4. r  `          G% \r\n                          J.` .!           % \r\n                            JiJ           .` \r\n                              .1.         J \r\n                                 ?1.     .'         \r\n                                     7<..%");
                            valido1 = true;
                            break;
                        case "b":
                            Console.Clear();

                            Console.WriteLine("              _______\r\n         ..-'`       ````---.\r\n       .'          ___ .'````.'SS'.\r\n      /        ..-SS####'.  /SSHH##'.\r\n     |       .'SSSHHHH##|/#/#HH#H####'.\r\n    /      .'SSHHHHH####/||#/: \\SHH#####\\\r\n   /      /SSHHHHH#####/!||;`___|SSHH###\\\r\n-..__    /SSSHHH######.         \\SSSHH###\\\r\n`.'-.''--._SHHH#####.'           '.SH####/\r\n  '. ``'-  '/SH####`/_             `|H##/\r\n  | '.     /SSHH###|`'==.       .=='/\\H|\r\n  |   `'-.|SHHHH##/\\__\\/        /\\//|~|/\r\n  |    |S#|/HHH##/             |``  |\r\n  |    \\H' |H#.'`              \\    |\r\n  |        ''`|               -     /\r\n  |          /H\\          .----    /\r\n  |         |H#/'.           `    /\r\n  |          \\| | '..            /\r\n  |    ^~DLF   /|    ''..______.'\r\n   \\          //\\__    _..-. | \r\n    \\         ||   ````     \\ |_\r\n     \\    _.-|               \\| |_\r\n     _\\_.-'   `'''''-.        |   `--.\r\n ''``    \\            `''-;    \\ /\r\n          \\      .-'|     ````.' -\r\n          |    .'  `--'''''-.. |/\r\n          |  .'               \\|\r\n          |.'");
                            valido1 = true;
                            break;
                        case "c":
                            Console.Clear();

                            Console.WriteLine("================================================.\r\n     .-.   .-.     .--.                         |\r\n    | OO| | OO|   / _.-' .-.   .-.  .-.   .''.  |\r\n    |   | |   |   \\  '-. '-'   '-'  '-'   '..'  |\r\n    '^^^' '^^^'    '--'                         |\r\n===============.  .-.  .================.  .-.  |\r\n               | |   | |                |  '-'  |\r\n               | |   | |                |       |\r\n               | ':-:' |                |  .-.  |\r\nl42            |  '-'  |                |  '-'  |\r\n==============='       '================'       |");
                            valido1 = true;
                            break;
                        default:
                            Console.Clear();

                            Console.WriteLine("Escoge una opción válida");
                            break;
                    }
                }
                break;
            case "c":
                valido = true;

                while (!valido1)
                {
                    Console.WriteLine("Escoge una opción para el Vehicles");
                    Console.WriteLine("a) Car \nb) Boat \nc) Truck ");

                    menu2 = Console.ReadLine();

                    switch (menu2)
                    {
                        case "a":
                            Console.Clear();

                            Console.WriteLine(" --          ~( @\\   \\\r\n---   _________]_[__/_>________\r\n     /  ____ \\ <>     |  ____  \\\r\n    =\\_/ __ \\_\\_______|_/ __ \\__D\r\n________(__)_____________(__)____");
                            valido1 = true;
                            break;
                        case "b":
                            Console.Clear();

                            Console.WriteLine("    __|__ |___| |\\\r\n    |o__| |___| | \\\r\n    |___| |___| |o \\\r\n   _|___| |___| |__o\\\r\n  /...\\_____|___|____\\_/\r\n  \\   o * o * * o o  /\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            valido1 = true;
                            break;
                        case "c":
                            Console.Clear();

                            Console.WriteLine("                       _____________________________________________________\r\n                      |                                                     |\r\n             _______  |                                                     |\r\n            / _____ | |                       ACME MOO-VERS                 |\r\n           / /(__) || |                                                     |\r\n  ________/ / |OO| || |                                                     |\r\n |         |-------|| |                                                     |\r\n(|         |     -.|| |_______________________                              |\r\n |  ____   \\       ||_________||____________  |             ____      ____  |\r\n/| / __ \\   |______||     / __ \\   / __ \\   | |            / __ \\    / __ \\ |\\\r\n\\|| /  \\ |_______________| /  \\ |_| /  \\ |__| |___________| /  \\ |__| /  \\|_|/\r\n   | () |                 | () |   | () |                  | () |    | () |\r\n    \\__/                   \\__/     \\__/                    \\__/      \\__/");
                            valido1 = true;
                            break;
                        default:
                            Console.Clear();

                            Console.WriteLine("Escoge una opción válida");
                            break;
                    }
                }
                break;
            case "d":
                valido = true;

                while (!valido1)
                {
                    Console.WriteLine("Escoge una opción para Weapons");
                    Console.WriteLine("a) Sword \nb) Gun \nc) Explosive ");

                    menu2 = Console.ReadLine();

                    switch (menu2)
                    {
                        case "a":
                            Console.Clear();

                            Console.WriteLine("              />\r\n (           //------------------------------------------------------(\r\n(*)OXOXOXOXO(*>                  --------                             \\\r\n (           \\\\--------------------------------------------------------)\r\n              \\>");
                            valido1 = true;
                            break;
                        case "b":
                            Console.Clear();

                            Console.WriteLine(" ,______________________________________       \r\n|_________________,----------._ [____]  \"\"-,__  __....-----=====\r\n               (_(||||||||||||)___________/   \"\"                |\r\n                  `----------' Krogg98[ ))\"-,                   |\r\n                                       \"\"    `,  _,--....___    |\r\n                                               `/           \"\"\"\"");
                            valido1 = true;
                            break;
                        case "c":
                            Console.Clear();

                            Console.WriteLine("                               ________________\r\n                          ____/ (  (    )   )  \\___\r\n                         /( (  (  )   _    ))  )   )\\\r\n                       ((     (   )(    )  )   (   )  )\r\n                     ((/  ( _(   )   (   _) ) (  () )  )\r\n                    ( (  ( (_)   ((    (   )  .((_ ) .  )_\r\n                   ( (  )    (      (  )    )   ) . ) (   )\r\n                  (  (   (  (   ) (  _  ( _) ).  ) . ) ) ( )\r\n                  ( (  (   ) (  )   (  ))     ) _)(   )  )  )\r\n                 ( (  ( \\ ) (    (_  ( ) ( )  )   ) )  )) ( )\r\n                  (  (   (  (   (_ ( ) ( _    )  ) (  )  )   )\r\n                 ( (  ( (  (  )     (_  )  ) )  _)   ) _( ( )\r\n                  ((  (   )(    (     _    )   _) _(_ (  (_ )\r\n                   (_((__(_(__(( ( ( |  ) ) ) )_))__))_)___)\r\n                   ((__)        \\\\||lll|l||///          \\_))\r\n                            (   /(/ (  )  ) )\\   )\r\n                          (    ( ( ( | | ) ) )\\   )\r\n                           (   /(| / ( )) ) ) )) )\r\n                         (     ( ((((_(|)_)))))     )\r\n                          (      ||\\(|(|)|/||     )\r\n                        (        |(||(||)||||        )\r\n                          (     //|/l|||)|\\\\ \\     )\r\n                        (/ / //  /|//||||\\\\  \\ \\  \\ _)\r\n-------------------------------------------------------------------------------");
                            valido1 = true;
                            break;
                        default:
                            Console.Clear();

                            Console.WriteLine("Escoge una opción válida");
                            break;
                    }
                }
                break;
            case "e":
                valido = true;

                while (!valido1)
                {
                    Console.WriteLine("Escoge una opción para Logos");
                    Console.WriteLine("a) Coca Cola\nb) BioHazards \nc) Kool-aid ");

                    menu2 = Console.ReadLine();

                    switch (menu2)
                    {
                        case "a":
                            Console.Clear();

                            Console.WriteLine("         __                              ___   __        .ama     ,\r\n      ,d888a                          ,d88888888888ba.  ,88\"I)   d\r\n     a88']8i                         a88\".8\"8)   `\"8888:88  \" _a8'\r\n   .d8P' PP                        .d8P'.8  d)      \"8:88:baad8P'\r\n  ,d8P' ,ama,   .aa,  .ama.g ,mmm  d8P' 8  .8'        88):888P'\r\n ,d88' d8[ \"8..a8\"88 ,8I\"88[ I88' d88   ]IaI\"        d8[         \r\n a88' dP \"bm8mP8'(8'.8I  8[      d88'    `\"         .88          \r\n,88I ]8'  .d'.8     88' ,8' I[  ,88P ,ama    ,ama,  d8[  .ama.g\r\n[88' I8, .d' ]8,  ,88B ,d8 aI   (88',88\"8)  d8[ \"8. 88 ,8I\"88[\r\n]88  `888P'  `8888\" \"88P\"8m\"    I88 88[ 8[ dP \"bm8m88[.8I  8[\r\n]88,          _,,aaaaaa,_       I88 8\"  8 ]P'  .d' 88 88' ,8' I[\r\n`888a,.  ,aadd88888888888bma.   )88,  ,]I I8, .d' )88a8B ,d8 aI\r\n  \"888888PP\"'        `8\"\"\"\"\"\"8   \"888PP'  `888P'  `88");
                            valido1 = true;
                            break;
                        case "b":
                            Console.Clear();

                            Console.WriteLine("                         __    _                                   \r\n                    _wr\"\"        \"-q__                             \r\n                 _dP                 9m_     \r\n               _#P                     9#_                         \r\n              d#@                       9#m                        \r\n             d##                         ###                       \r\n            J###                         ###L                      \r\n            {###K                       J###K                      \r\n            ]####K      ___aaa___      J####F                      \r\n        __gmM######_  w#P\"\"   \"\"9#m  _d#####Mmw__                  \r\n     _g##############mZ_         __g##############m_               \r\n   _d####M@PPPP@@M#######Mmp gm#########@@PPP9@M####m_             \r\n  a###\"\"          ,Z\"#####@\" '######\"\\g          \"\"M##m            \r\n J#@\"             0L  \"*##     ##@\"  J#              *#K           \r\n #\"               `#    \"_gmwgm_~    dF               `#_          \r\n7F                 \"#_   ]#####F   _dK                 JE          \r\n]                    *m__ ##### __g@\"                   F          \r\n                       \"PJ#####LP\"                                 \r\n `                       0######_                      '           \r\n                       _0########_                                   \r\n     .               _d#####^#####m__              ,              \r\n      \"*w_________am#####P\"   ~9#####mw_________w*\"                  \r\n          \"\"9@#####@M\"\"           \"\"P@#####@M\"\"              ");
                            valido1 = true;
                            break;
                        case "c":
                            Console.Clear();

                            Console.WriteLine("  ___  ____            _           ____      _     _  \r\n |   |/   /           | |         /    \\    (_)   | | \r\n |   '   /  ___   ___ | |  ___   /   _  \\    _  __| | \r\n |      <  / _ \\ / _ \\| | |___| /   (_)  \\  | |/ _` | \r\n |   .   \\| (_) | (_) | |      /   ____   \\ | | (_) | \r\n |___|\\___\\\\___/ \\___/|_|     /___/    \\___\\|_|\\__,_| \r\n     _______________          ____________            \r\n    ( _____________ ) ___    (            )           \r\n    /    _     _    \\/ _ \\   (  OH YEAH!  )           \r\n   /    (,)   (,)    \\/ \\ \\ /_____________)           \r\n  |         _         | | |               _______     \r\n  |        (_)        | | |   _______    (  . .  )_   \r\n  |     .       .     |/ /   (  . .  )_  |   o   |_)  \r\n   \\     '.....'     /__/    |   o   |_)  ) '-' (     \r\n    \\               /         ) '-' (    (_______)    \r\n     )_____________(         (_______)                \r\n____(_______________)_________________________________\r\n   ______            __    __    __                   \r\n  / __/ /  ___ _____/ /__ / /__ / /  ___ __________ __\r\n _\\ \\/ _ \\/ _ `/ __/  '_// / -_) _ \\/ -_) __/ __/ // /\r\n/___/_//_/\\_,_/_/ /_/\\_\\/_/\\__/_.__/\\__/_/ /_/  \\_, / \r\n                         ___ _                 /___/  \r\n                        / __(_)__                    \r\n                       / _// / _ \\                  \r\n            ____      /_/ /_/_//_/        __          \r\n           / __/__  _______ _  _____ ____/ /          \r\n          / _// _ \\/ __/ -_) |/ / -_) __/_/           \r\n         /_/  \\___/_/  \\__/|___/\\__/_/ (_)");
                            valido1 = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Escoge una opción válida");
                            break;
                    }
                }
                break;
                
                // Solicitar la entrada valida y regresa al inicio
            default:
                Console.Clear();
                Console.WriteLine("Escoge una opción válida");
                break;
        }
        break;
    }

    // if para validar los valores de valido  y valido1 hasta que se cumplan para terminar el programa
   
    if (valido && valido1)
    {
        programa = true;
    }

}
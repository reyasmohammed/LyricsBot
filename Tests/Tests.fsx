#reference "../bin/Debug/netstandard2.0/bin/LyricsBot.dll"

open LyricsBot.Telegram

let message = 
    "[Hook: Brotha Lynch Hung]
    That motherfucker kept sniffing for goods
    Put the plastic in his mouth the back of his neck left
    And you don't know nothing but the killer got away
    Before 4:30 in the morning I'm gone in the 6-Tre
    With the windows up, must have had gin in the cup
    Cuz I'm swervin in the fast-lane gotta be spinning em up
    (X-caliba)

    [Verse 1: Brotha Lynch Hung]
    It all started when I twisted the lid of the Olde E
    And C-A-R-I-double-O-E imported LTD
    Where my motherfuckering siccmade jacket at
    Cause that's the only one I could use
    When I saw you at the war yeah when I lifted you out your shoes
    It was that pressure from the 20-gauge (that 20-gauge)
    Felt like it cause your chest split wide open with it
    Well nigga you shouldn't went around talking that shit
    Bout the nigga that's my kin-folks
    Should knew the real while you was giving up that info...
    ...mation, I'll be of that Parry Mason
    When I hit em all up, grip em all up, rip em, kill em all up, fill em all up, lick em, real em, deal em, dig a ditch give em hit a lick then take the grip
    Put em in the back of the Cadillac
    Show em how my Mini-Mac gonna act
    My tactics is lethal
    Leave the whole town hella smokey
    Like the bandits that stepping over dead people
    It's like that
    And you wouldn't know it cause I'ma cool ass motherfucker
    Then dump with a gang of suckers
    As I wait for the city to heat up like a Hot Pepper
    Got a whole load full of Evian
    And a trunk full of FO take no's and I can't let go
    Catch you at yo show slipping
    Hoes tripping
    Rows ripping
    In the street after I heat my heat off the hook with this siccmade shit
    Straight made nigga
    Fuck it, pass me the straight lace liquor
    To the face nigga
    Off the Thunderbird and Kool-Aid and O 8
    Easy on the liver still make me kill a nigga
    Split you head like a pineapple
    Die natural!
    Five at your dome send em home in a pinebox
    Lift you out your socks
    Pay attention to the Glock
    Half past a niggas ass lay him in the grass take suitcase full of cash and mash
    16 in the clip crumble the herb roll a spliff bout to watch your brain split in half
    Bloody bath water and fried nigga nuts and bones
    Located at home I think him name is Tyrone
    But you know...

    [Hook]
    That motherfucker kept sniffing for goods
    Put the plastic in his mouth the back of his neck left
    And you don't know nothing but the killer got away
    Before 4:30 in the morning I'm gone in the 6-Tre
    With the windows up, must have had gin in the cup
    Cuz I'm swervin in the fast-lane gotta be spinning em up
    (X-caliba)

    [Verse 2]
    You can call me black Saddam Hussein
    Pump cyanide through my vein ass nigga
    You can see me on the south side of the street
    Marinated by the opposite nigga that flood the city
    Get ready for something pretty if you sick like Frank Nitty
    Sucked blood from my mommas titties - instead of milk
    Played murder music in my tape deck - instead of Silk
    Ende up killen one of them motherfuckers
    So fuck them hoes, they like Grim
    Having killin niggas like they gots to go
    Woke up at 3AM - got high til seven
    Jump in what you call it headin towards heaven
    With my 50 sack of some shit, that'll make you get there
    About 11:30 with your T-shirt dirty
    I'm worthy strapped like James as ventured in this faulty game
    In a mainframe, that I bucked in ruff terrain, then hit the plane
    15 guts on a triple beam scale nigga
    Actual contact from the strap that I hale nigga

    [Hook]
    That motherfucker kept sniffing for goods
    Put the plastic in his mouth the back of his neck left
    And you don't know nothing but the killer got away
    Before 4:30 in the morning I'm gone in the 6-Tre
    With the windows up, must have had gin in the cup
    Cuz I'm swervin in the fast-lane gotta be spinning em up
    (X-caliba)

    [Verse 3]
    They got this motherfucker twisted up
    And from the sound of the barrel I got hella motherfuckers running up
    What should I do about these fucking fleas?
    Give em all A-1 and put they disease in they weed
    Figure a way out this nigga I know you got me on file
    But I got you on scanner so plan another way (another way)
    Told me it was copasetic
    But I catch you slipping like pimping
    And shake and bake you like ?
    Hit your mind, burgundy slime drips
    Time gets deeper as you meet the Grim Reaper
    In the form of a man double M 24 5 got your brains leaking I'm peaking
    That's why these niggas wanna rip keep me
    I'm rolling squeaky and what you want call it
    With a .45 in my pocket and I'm a young alcoholic
    Like P-Folks I had to make it happen
    Sacramento's most wanted I gotta keep packing, cause of that
    My favorite cousin just got four years
    And when his little brother died he showed me no tears
    What's your point?
    Point is shit gets deep as the ocean
    Take a shiesty niggas blood and rub it on like lotion
    It was like, once upon a time a long time ago
    I was sticking 9 millis in a pussy hole
    Get of the Ol 8 old murder mo then i gotta go to a spot
    Where they don't know I'm deleting niggas that be given up my info

    [Hook]
    That motherfucker kept sniffing for goods
    Put the plastic in his mouth the back of his neck left
    And you don't know nothing but the killer got away
    Before 4:30 in the morning I'm gone in the 6-Tre
    With the windows up, must have had gin in the cup
    Cuz I'm swervin in the fast-lane gotta be spinning em up
    (X-caliba)"

splitMessage message |> List.iter(fun x -> printf "%s" x; printf "\n--------------------------\n")
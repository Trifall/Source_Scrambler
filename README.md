# Source_Scrambler
Adds junk and reorders code in order to change the hash of the respective modules. Can be used to bypass certain detection methods that rely on those hashes, or can be used to further obfuscate code.

Only operates on the file extensions:
```
.cpp
.h
.hpp
```

Note: You may need to adjust your compilers settings to not remove unused variables in these specific files, otherwise they may be optimized out.

<b><h2>Current Tags</h2></b>


<h4>Swap Lines</h4> - Swaps individual lines between two markers.

    Usage:

        [swap_lines] - Starting marker for section of lines to be swapped.
        
        [/swap_lines] - Ending marker for the section of lines to be swapped.

<h4>Swap Blocks</h4> - Swaps different marked blocks (useful for functions) around randomly.
    
    Usage:
        
        [swap_blocks] - Marks the starting point of the section where blocks are.
        
        [block] - Marks the starting point of an individual block. (inside of [swap_blocks])
       
        [/block] - Marks the ending point of an individual block. (inside of [swap_blocks])
        
        [/swap_blocks] - Marks the ending point of the seciton where blocks are.

<h4>Add Junk Lines</h4> - Adds lines after every valid line (line that contains ;).
    
    Usage:
        
        [add_junk_lines] - Starting point of the auto line generation section.
        
        [/add_junk_lines] - Ending point marker of the auto line generation section.
    
    Extra:
        
        Has chance for if statements to be randomly generated.

<h4>Add Junk Block</h4> - Adds a randomly generated junk block at the marker.
    
    Usage:
        
        [add_junk_block /] - Generates the junk block at the current location.
    
    Extra:
        
        Has chance for if statements to be randomly generated.

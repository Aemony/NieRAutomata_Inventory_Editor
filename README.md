# NieR: Automata - Inventory Editor
Work in progress inventory editor for NieR:Automata. **This is a work in progress** so expect issues. Please be aware that I am making random assumptions while creating this editor, which might or might not be true. For example, the "inactive/corpse" inventory is something I haven't actually verified. It was, however, the only explanation I could come up with why the 512 inventory block suddenly split off at the half of it.

**MAKE BACKUPS BEFORE USING THIS!**

For use with this fantastic resource: https://docs.google.com/spreadsheets/d/1HQc9XkppRgNEFQ5zLgQW6BTqyFrPf2P6DxKz8x2S2oU/

## Features

* Edit your inventory "easily".

## Requirement

* .NET Framework 4

## Known Issues

* Can't make an item slot "unused" since the middleware I'm using for the gridview writes 99999999 instead.
* No telling what havoc this editor can cause.

## Usage

1. Download the editor from [the release section](https://github.com/Idearum/NieRAutomata_Inventory_Editor/releases).

2. Run the tool and open one of the SlotData_#.dat files of NieR:Automata:

   - **SlotData_#.dat** stores slot progression for slot 1-3.
   
3. Use this Google spreadsheet to locate the appropriate item ID: https://docs.google.com/spreadsheets/d/1HQc9XkppRgNEFQ5zLgQW6BTqyFrPf2P6DxKz8x2S2oU/

4. Double click on a cell to change the value of it.

5. The editor is basic, so for now you'll have to manually change the "Status" of a row for it to show up in-game:

    **458752** - "Active Item Slot" ? To be determined...
    
    **4294967295** - "Unused Item Slot" ? To be determined...
    
6. Click on Save when ready to save the file.

## Preview

![Screenshot of the editor](screenshot.png "Screenshot of the editor")

## License

See [LICENSE](LICENSE).

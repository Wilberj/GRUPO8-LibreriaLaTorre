export default function CreateDropDown(Dataset = [],
    Select,
    Display = "",
    Value = "",
    SelectFunction) {
    if (SelectFunction) {
        Select.onchange = SelectFunction;
    }
    Dataset.forEach((Item, Index) => {
        const Options = document.createElement("option");
        Options.innerText = Item[Display];
        Options.value = Item[Value];
        Select.append(Options);
    });
}
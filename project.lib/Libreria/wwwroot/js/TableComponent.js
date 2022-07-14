export default function CreateTable(Dataset = [], Table, TableFunction, BtnValue = "Editar") {
    const thead = Table.querySelector("thead");
    const tbody = Table.querySelector("tbody");
    thead.innerHTML = "";
    tbody.innerHTML = "";
    Dataset.forEach((Item, Index) => {
        const row = document.createElement("tr");

        for (var prop in Item) {
            console.log("Item",Item)
            const td = document.createElement("td");
            if (prop == 'estado') {

                td.innerHTML = Item[prop] == 1 ? 'Activo' : 'Inactivo';


                console.log("activo");
            } else {
                td.innerHTML = Item[prop];
            }

            row.append(td);
            if (Index == 0) {
                const th = document.createElement("th");
                th.innerText = prop;

                thead.append(th);

            }
        }
        if (Index == 0) {
            const th = document.createElement("th");
            th.innerText = "actions";
            thead.append(th);
        }
        const tdAction = document.createElement("td");
        const btn = document.createElement("input");
        btn.className = "btn btn-primary";
        btn.type = "Button";
        btn.value = BtnValue;
        btn.onclick = () => {
            TableFunction(Item);
        }

        tdAction.append(btn);
        row.append(tdAction);
        tbody.append(row);
    });
}
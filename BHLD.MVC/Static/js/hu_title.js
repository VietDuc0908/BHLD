const apiUrl = "/api/";

async function CallApi(endpoint, method = "GET", body = null) {
    var url = apiUrl + endpoint;
    const resp = await fetch(url, {
        method,
        headers: {
            "Content-Type": "application/json"
        },
        body
    });
    return resp.json();
}


CallApi("hu_tilte").then(res => {
    if (res) {
        const SELECT_HU_TITLE = document.getElementById("hu_title");
        res.forEach(tittle => {
            const OPTIONELM = `
<td>${tittle.code }</td>
<td>${tittle.title_name}</td>
<td>${tittle.remark }</td>
<td>${tittle.actflg }</td>
<td>${tittle.created_by }</td>
<td>${tittle.created_date }</td>
<td>${tittle.created_log}</td>
<td>${tittle.modified_date }</td>
<td>${tittle.status   }</td>`;


            SELECT_HU_TITLE.insertAdjacentHTML("beforeend", OPTIONELM);
        })
    }
})
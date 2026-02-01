const scanBtn = document.getElementById("scanBtn");
const scanStatus = document.getElementById("scanStatus");
const results = document.getElementById("results");
const table = document.getElementById("threatsTable");

scanBtn.addEventListener("click", () => {
    results.classList.add("hidden");
    scanStatus.classList.remove("hidden");
    scanBtn.disabled = true;

    setTimeout(runScanSimulation, 2500);
});

function runScanSimulation() {
    scanStatus.classList.add("hidden");
    scanBtn.disabled = false;
    results.classList.remove("hidden");

    threats = [
        {
            id: 1,
            name: "BadBot.exe",
            path: "/usr/bin/BadBot.exe",
            level: "High",
            blocked: false
        },
        {
            id: 2,
            name: "UnknownMiner",
            path: "/tmp/miner",
            level: "Medium",
            blocked: false
        }
    ];

    renderThreats();
}

function renderThreats() {
    table.innerHTML = "";

    threats.forEach(t => {
        const tr = document.createElement("tr");
        tr.className = t.level.toLowerCase();

        tr.innerHTML = `
            <td>${t.name}</td>
            <td>${t.path}</td>
            <td>${t.level}</td>
            <td>
                <button class="block" ${t.blocked ? "disabled" : ""}>
                    ${t.blocked ? "Blocked" : "Block"}
                </button>
            </td>
            <td>
                <button class="remove">Remove</button>
            </td>
        `;

        // Block
        tr.querySelector(".block").onclick = () => {
            t.blocked = true;
            renderThreats();
        };

        // Remove
        tr.querySelector(".remove").onclick = () => {
            threats = threats.filter(x => x.id !== t.id);
            renderThreats();
        };

        table.appendChild(tr);
    });

    if (threats.length === 0) {
        table.innerHTML = `<tr><td colspan="5">System clean ✔</td></tr>`;
    }
}

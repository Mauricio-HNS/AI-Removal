const scanBtn = document.getElementById("scanBtn");
const scanStatus = document.getElementById("scanStatus");
const results = document.getElementById("results");
const table = document.getElementById("threatsTable");

scanBtn.addEventListener("click", () => {
    results.classList.add("hidden");
    scanStatus.classList.remove("hidden");
    scanBtn.disabled = true;

    // Simula tempo de scan
    setTimeout(runScanSimulation, 3000);
});

function runScanSimulation() {
    scanStatus.classList.add("hidden");
    scanBtn.disabled = false;
    results.classList.remove("hidden");

    const threats = [
        {
            name: "BadBot.exe",
            path: "/usr/bin/BadBot.exe",
            level: "High",
            blocked: true,
            removed: false
        },
        {
            name: "UnknownMiner",
            path: "/tmp/miner",
            level: "Medium",
            blocked: false,
            removed: false
        }
    ];

    renderThreats(threats);
}

function renderThreats(threats) {
    table.innerHTML = "";

    threats.forEach(t => {
        const tr = document.createElement("tr");
        tr.className = t.level.toLowerCase();

        tr.innerHTML = `
            <td>${t.name}</td>
            <td>${t.path}</td>
            <td>${t.level}</td>
            <td>${t.blocked ? "Yes" : "No"}</td>
            <td>${t.removed ? "Yes" : "No"}</td>
        `;

        table.appendChild(tr);
    });
}

// WebBase made by CC15XX1 (Do NOT delete this comment.)
let info = {
    name: 'WebBase',
    version: 0.1,
    creator: 'CC15XX1'
};
var watermark = document.getElementById("watermark");
var creator = document.getElementById("creator");

watermark.innerText = info.name + " v" + info.version;
creator.innerText = "Made by " + info.creator;

console.log(info.name + " v" + info.version);
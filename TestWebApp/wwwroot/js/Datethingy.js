const fromDate = document.getElementById("fromDate")
const toDate = document.getElementById("toDate")
let shootingData = []

async function getAthleteTrainingSessions(ibuId) {
    let url = `https://localhost:7026/api/${ibuId}?toDate=${toDate.value}&fromDate=${fromDate.value}`
    await fetch(url)
        .then(response => response.json())
        .then(data => shootingData = data)
    console.log(shootingData)
    setTrainingSessionsOnDates()
}

function getTrainingSessionOnDate(date){
    // let trainingSession = shootingData.find(ts => ts.date.toString().substring(0,10) === date.toString().substring(0,10))
    let trainingSession = shootingData.filter(ts => ts.date.toString().substring(0,10) === date.toString().substring(0,10))
    console.log(trainingSession)
}

function setTrainingSessionsOnDates(){
    let days = document.getElementsByClassName("day")
    for(let day of days) {
        const trainingSession = shootingData.find(ts => ts.date.toString().substring(8,10) === day.id)
        if(trainingSession){
            let sc = day.querySelector(".seriesCount")
            sc.textContent = trainingSession.results.length;
            day.addEventListener('click', function (){getTrainingSessionAndDoWhateverYouWant(trainingSession)})
        }
    }
}

function getTrainingSessionAndDoWhateverYouWant(trainingSession){
    console.log(trainingSession)
}
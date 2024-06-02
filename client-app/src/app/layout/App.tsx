import { useEffect, useState } from 'react'
import './styles.css'
import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import GoalSeekDashboard from './dashboard/GoalSeekDashboard';
import { GoalSeek } from '../models/goalSeek';
import agent from '../api/agent';

function App() {
  const [goalSeek, SetGoalSeek] = useState<GoalSeek>();
  //const [weather, SetWeather] = useState<Weather>();

  useEffect(() => {
    
    /*axios.get<Weather>('http://localhost:5000/weatherforecast').then(response => {
      SetWeather(response.data)
    });*/
    
    agent.GoalSeekCalculation.create(goalSeek).then(response => {
      SetGoalSeek(response.data)
      console.log("response.data", response.data);
    });
  }, []);

  function handleGoalSeekCalculate(goalSeek: GoalSeek) {

    SetGoalSeek(goalSeek)
    agent.GoalSeekCalculation.create(goalSeek).then(response => {
      SetGoalSeek(response?.data)
      console.log("response.data", goalSeek);
    });
  }

  return (
    <>
      <NavBar />
      <Container style={{marginTop: '7em'}}>
          <GoalSeekDashboard goalSeek={goalSeek} create={handleGoalSeekCalculate}/>
      </Container>
    </>
  )
}

export default App

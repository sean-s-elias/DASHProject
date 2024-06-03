import { useState } from 'react'
import './styles.css'
import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import GoalSeekDashboard from './dashboard/GoalSeekDashboard';
import { GoalSeek } from '../models/goalSeek';
import agent from '../api/agent';

function App() {
  const [goalSeek, SetGoalSeek] = useState<GoalSeek>();

  function handleGoalSeekCalculate(goalSeek: GoalSeek) {

    SetGoalSeek(goalSeek);

    agent.GoalSeekCalculation.create(goalSeek).then(response => {
      SetGoalSeek(response?.data);
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

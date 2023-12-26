import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  // State destroied when the app is closed. a state is a child componenet, it is destroyed when the child is closed.
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/v1/activities')
        .then(response => {
            setActivities(response.data)
        })
  }, [])

  return (
    <div>         
      <Header as='h2' icon='users' content='React App' />
      <List>
        {activities.map((activity: any) => (
            <List.Item key={activity.id}>
                  {activity.title}
            </List.Item>
        ))}
      </List>
    </div> 
  )
}

export default App

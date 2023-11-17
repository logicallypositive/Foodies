import { useEffect, useState } from 'react';
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [foods, setFoods] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/foods')
      .then(response => {
        setFoods(response.data)
      })
  },[])

  return (
    <div>
      <Header as='h2' icon='food' content='Food List' />

      <ul>
        {foods.map((food: any) => (
          <List.Item key={food.id}>
            <Header as='h3' content ={food.name}/>
            <Header as='h4' content ='Ingredients'/>
            <p>{food.ingredients}</p>
            <Header as='h4' content ='Description'/>
            <p>{food.description}</p>
            <br />
          </List.Item>
        ))}
      </ul>

    </div>
  )
}

export default App

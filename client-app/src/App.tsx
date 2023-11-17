import { useEffect, useState } from 'react';
import './App.css'
import axios from 'axios';

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
      <h1>We are foodies!</h1>

      <ul>
        {foods.map((food: any) => (
          <li key={food.id}>
            {food.name}
          </li>
        ))}
      </ul>

    </div>
  )
}

export default App
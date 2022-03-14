import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import Tarefa from './src/pages/Tarefa';
import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';

export default function App() {
  const Stack = createStackNavigator();

  return (
    <NavigationContainer>
      <Stack.Navigator initialRouteName='Tarefa'>
        <Stack.Screen
          name='Tarefas'
          component={Tarefa}
          options={{ headerTintColor: '#f92e6a' }} />
        <Stack.Screen
          name='Novas Tarefas'
          component={Tarefa}
          options={{ headerTintColor: '#f92e6a' }} />
        <Stack.Screen
          name='Detalhes'
          component={Tarefa}
          options={{ headerTintColor: '#f92e6a' }} />
      </Stack.Navigator>

    </NavigationContainer>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});

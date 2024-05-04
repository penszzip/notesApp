import React, { useEffect, useState } from 'react'
import Note from './Note';
import AddNote from './AddNote';
import Search from './Search'
import { nanoid } from 'nanoid'

const Notes = () => {
    const [notes, setNotes] = useState([
        {
            id: nanoid(),
            text: 'This is a note!',
            date: '15/04/2024',
        },
        {
            id: nanoid(),
            text: 'This is a note!',
            date: '17/04/2024',
        },
        {
            id: nanoid(),
            text: 'This is a note!',
            date: '19/04/2024',
        },
        {
            id: nanoid(),
            text: 'This is a note!',
            date: '20/04/2024',
        },
        {
            id: nanoid(),
            text: 'This is a note!',
            date: '21/04/2024',
        },
    ]);

    const [searchText, setSearchText] = useState('');

    // useEffect(() => {
    //     const fetchNotes = async () => {
    //         fetch("http://localhost:5111/api/notes")
    //             .then(response => {
    //                 if (!response.ok) {
    //                     throw new Error(`HTTP error! status: ${response.status}`);
    //                 }
    //                 return response.json();
    //             })
    //             .then(data => console.log(data))
    //             .catch(error => console.log('There was a problem with the fetch operation: ' + error.message));
    //     }
    //     fetchNotes()
    // }, [])

    //Function to add note which is passed to AddNote component
    const handleAddNote = (text) => {
        const date = new Date();
        const newNote = {
            id: nanoid(),
            text: text,
            date: date.toLocaleDateString()
        };
        //make fetch POST request to server /api/notes 
        const newNotes = [...notes, newNote];
        setNotes(newNotes);
    }

    const handleDeleteNote = (id) => {
        const newNotes = notes.filter(note => note.id !== id);
        //make fetch DELETE to server /api/notes
        setNotes(newNotes);
    }

    return (
        <>
            <Search handleSearchNote={setSearchText} />
            <div className='notes-list'>
                {notes
                    .filter((note) =>
                        note.text.toLowerCase().includes(searchText)
                    )
                    .map((note) =>
                        <Note 
                        key={note.id} 
                        id={note.id} 
                        text={note.text} 
                        date={note.date} 
                        handleDeleteNote={handleDeleteNote} 
                        />
                    )}
                <AddNote handleAddNote={handleAddNote} />
            </div>
        </>
    )
}

export default Notes;
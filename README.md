 # Note API

![NotApp](https://github.com/serifetoy/Eczacibasi.Web.NoteApp/assets/92857592/cb14686a-3124-4d1a-a6eb-a9598e4fc3c9)

This project includes an API design for a note-taking application. It is developed using .NET 5 Web API.

## Project Structure

The project contains a `NoteController` which provides API endpoints for performing operations related to notes. The operations include retrieving notes, retrieving details of a specific note, adding a new note, updating a note, and deleting a note.

## Usage

The following API endpoints are available:

- `GET /notes`
  - Retrieves all notes.
- `GET /notes/{id}`
  - Retrieves details of a specific note.
- `POST /notes`
  - Adds a new note.
- `PUT /notes/{id}`
  - Updates a specific note.
- `DELETE /notes/{id}`
  - Deletes a specific note.

### Note Properties

Each note has the following properties:

- `Id`: The unique identifier of the note.
- `Title`: The title of the note.
- `Content`: The content of the note.
- `Category`: The category of the note.
- `PublishDate`: The publication date of the note.


## License

This project is licensed under the MIT License. For more information, see the [LICENSE](LICENSE) file.


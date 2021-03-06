﻿using Dopamine.Data;
using Dopamine.Data.Entities;
using Dopamine.Services.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dopamine.Services.Collection
{
    public interface ICollectionService
    {
        Task<RemoveTracksResult> RemoveTracksFromCollectionAsync(IList<TrackViewModel> selectedTracks);

        Task<RemoveTracksResult> RemoveTracksFromDiskAsync(IList<TrackViewModel> selectedTracks);

        Task MarkFolderAsync(Folder folder);

        Task<IList<ArtistViewModel>> GetAllArtistsAsync(ArtistType artistType);

        Task<IList<GenreViewModel>> GetAllGenresAsync();

        Task<IList<AlbumViewModel>> GetAllAlbumsAsync();

        Task<IList<AlbumViewModel>> GetArtistAlbumsAsync(IList<string> selectedArtists);

        Task<IList<AlbumViewModel>> GetGenreAlbumsAsync(IList<string> selectedGenres);

        Task<IList<AlbumViewModel>> OrderAlbumsAsync(IList<AlbumViewModel> albums, AlbumOrder albumOrder);

        Task<IList<TrackViewModel>> GetArtistTracksAsync(IList<string> selectedArtists, TrackOrder trackOrder);

        Task<IList<TrackViewModel>> GetAlbumsTracksAsync(IList<string> selectedAlbumKeys, TrackOrder trackOrder);

        Task<IList<TrackViewModel>> GetGenreTracksAsync(IList<string> selectedGenres, TrackOrder trackOrder);

        event EventHandler CollectionChanged;
    }
}

def song_decoder(song):
    song = song.split("WUB")
    nSong = ([])
    for i in song:
        if i != '': nSong.append(i)
    song = " ".join(nSong)
    return song